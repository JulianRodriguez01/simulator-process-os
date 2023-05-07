using iTextSharp.text;
using ProyectProcess.persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectProcess.models {

    public class Simulator
    {

        public static int MAX_NEXT_PROCESS_TIME = 3; /*Random*/
        public static int MAX_PROCESS_LIFE_TIME = 20; /*Random*/
        public static int MAX_NEXT_IO_TIME = 4; /*Random*/
        public static int MAX_IO_TIME = 4; /*Random*/
        public static int QUANTUM = 3;

        private int clock;
        private int idProcess;
        private int nextProcessTime;
        private Status cpuStatus;        
        private Process actualProcess;
        private WritteFile writteFile;
        private ReadFile readFile;
        private Random random;
        public List<Process> processList;
        public List<String> listEvents;
        public List<String> actualEvents;

        public Simulator()
        {
            random = new Random();
            processList = new List<Process>();
            listEvents = new List<String>();
            actualEvents = new List<String>();
            writteFile = new WritteFile();
            readFile = new ReadFile();
        }

        public void initVars()
        {
            cpuStatus = Status.IDLE;
            actualProcess = null;
            clock = 1;
            idProcess = 1;            
            nextProcessTime = 0;
            writteFile.clearDoc();
        }

        public List<Process> getProcessesList() {return processList; }

        public void removeProcess(int id) { processList.Remove(processList[searchProcess(id)]); }

        public List<string> getListEvents() { return listEvents; }

        public Process getActualProcess() {return actualProcess; }

        public Status getCpuStatus() {return cpuStatus; }

        public string getTextFile() { return readFile.getTextFile(); }

        public int searchProcess(int idProcess)
        {
            int i = 0;
            foreach (Process process in processList)
            {
                if (process.getIdProcess() == idProcess) { return i; }
                i++;
            }
            return -1;
        }

        public List<Process> getListProcessStatus(Status status)
        {
            List<Process> listAux = new List<Process>();
            foreach (Process process in processList)
            {
                if (process.getStatus() == status) { listAux.Add(process); }
            }
            return listAux;
        }

        public void getOttersEvents()
        {
            listEvents.Add("The next process will created in " + nextProcessTime);
            if (cpuStatus == Status.IDLE)
            {
                listEvents.Add("CPU is IDLE!");
                actualEvents.Add("CPU is IDLE!");
            }
        }

        public void writteHeader()
        {
            initVars();
            writteFile.writteTextFile(actualProcess, cpuStatus, getListProcessStatus(Status.ready), getListProcessStatus(Status.blocked), nextProcessTime, clock);
            writteActualEvents();
        }

        public void startSimulator() {
            verifyActualProcessBlocked();
            verifyFinishProcess();            
            getOttersEvents();
            validateValues();
            addProcess();
            updateTime();
            actualEvents.Clear();
            clock++;
        }

        private void addProcess() { 
            if (nextProcessTime == 0 || cpuStatus == Status.IDLE) {
                validateActualProcess();
                assignProcess();
                nextProcessTime = random.Next(1, MAX_NEXT_PROCESS_TIME);
            } else {
                nextProcessTime--;  
            }
            writteFile.writteTextFile(actualProcess, cpuStatus, getListProcessStatus(Status.ready), getListProcessStatus(Status.blocked), nextProcessTime, clock);
            writteActualEvents();
        }

        public void writteActualEvents()
        {
            foreach(var actual in actualEvents) { 
                writteFile.writteText(actual);
            }
        }

        public void validateActualProcess() {
            int value = (actualProcess != null) ? actualProcess.getIdProcess() + 1: 1;
            listEvents.Add("Process " + value + " was created.");
            listEvents.Add("Process " + value + " was assigned to CPU.");
            actualEvents.Add("Process " + value + " was created.");
            actualEvents.Add("Process " + value + " was assigned to CPU.");
        }

        private Process createProcess()
        {
            return new Process(idProcess++, random.Next(1, MAX_PROCESS_LIFE_TIME), random.Next(1, MAX_NEXT_IO_TIME),
                random.Next(1, MAX_IO_TIME), QUANTUM);
        }

        public void assignProcess() {
            Process process = createProcess();
            if (cpuStatus == Status.IDLE) { validateListStatus(process); }
            else {
                process.setStatus(Status.ready);
                processList.Add(process);
                listEvents.Add("Process " + actualProcess.getIdProcess() + " was assigned to ready processes queue.");
                actualEvents.Add("Process " + actualProcess.getIdProcess() + " was assigned to ready processes queue.");
            }
        }

        private void validateListStatus(Process process)
        {
            List<Process> list = getListProcessStatus(Status.ready);
            if (list.Count() > 0)
            {
                actualProcess = list[0];
                removeProcess(actualProcess.getIdProcess());
            }
            else { actualProcess = process; }
            cpuStatus = Status.BUSY;
            process.setStatus(Status.running);
        }

        public void updateTime()
        {
            if (actualProcess != null) {
                int lifeTime = actualProcess.getLifeTime() - 1;
                int nextIO = actualProcess.getNextIo() - 1;
                int quantum = actualProcess.getQuantum() - 1;
                actualProcess.setLifeTime(lifeTime);
                actualProcess.setNextIo(nextIO);
                actualProcess.setQuantum(quantum);
            }           
        }

        public void verifyFinishProcess() {
            if (actualProcess != null && actualProcess.getIO() == 0) {
                actualProcess.setStatus(Status.finish);
                listEvents.Add("Status of process " + actualProcess.getIdProcess() + " is FINISH.");
                actualEvents.Add("Status of process " + actualProcess.getIdProcess() + " is FINISH.");
            }
        }

        public void verifyActualProcessBlocked() {
            List<Process> list = getListProcessStatus(Status.blocked);
            if (list.Count() > 0 && actualProcess != null)
            {
                int ioActual = list[0].getIO();
                if (ioActual > 0) {                    
                    processList[searchProcess(list[0].getIdProcess())].setIO(--ioActual);
                }
                else
                {
                    int lifeTime = actualProcess.getLifeTime();
                    int nextIO = actualProcess.getNextIo();
                    int quantum = actualProcess.getQuantum();
                    blockProcess(ref lifeTime, ref nextIO, ref quantum);
                    actualProcess = processList[searchProcess(list[0].getIdProcess())];
                    actualProcess.setNextIo(random.Next(1, MAX_NEXT_IO_TIME));
                    actualProcess.setQuantum(QUANTUM);  
                }               
            }
        }

        public void validateValues() {
            if (actualProcess != null) {
                int lifeTime = actualProcess.getLifeTime();
                int nextIO = actualProcess.getNextIo();
                int quantum = actualProcess.getQuantum();
                if (lifeTime < 0 || nextIO < 0 || quantum < 0) { blockProcess(ref lifeTime, ref nextIO, ref quantum); }
            }
        }

        private void blockProcess(ref int lifeTime, ref int nextIO, ref int quantum)
        {
            actualProcess.setStatus(Status.blocked);
            actualProcess.setLifeTime(++lifeTime);
            actualProcess.setNextIo(++nextIO);
            actualProcess.setQuantum(++quantum);
            processList.Add(actualProcess);
            cpuStatus = Status.IDLE;
            listEvents.Add("Status of process " + actualProcess.getIdProcess() + " is BLOCKED.");
            actualEvents.Add("Status of process " + actualProcess.getIdProcess() + " is BLOCKED.");
        }
    }
}
