using ProyectProcess.models;
using System.Net.NetworkInformation;
using Process = ProyectProcess.models.Process;

namespace ProyectProcess.persistence
{
    public class WritteFile
    {
        public static string PATH_FILE = "../../../output/register.txt";
        
        private StreamWriter sw;
        private int processCreated = 1;
        private int processAssigned = 1;

        public WritteFile() {
            sw = new StreamWriter(PATH_FILE);
            sw.Close();
        }

        public void clearDoc() {
            sw = new StreamWriter(PATH_FILE);
            sw.Close();
            processCreated = 1;
            processAssigned = 1;
        }

        public void writteTextFile(Process actualProcess, Status cpuStatus, List<Process> processReadyList, List<Process> processBlockList, int nextProcessTime, int clock)
        {
            sw = new StreamWriter(PATH_FILE, true);
            sw.WriteLine("--------------------------------------------------------------------------------");
            verifyActualProcess(actualProcess, cpuStatus, clock, sw);
            sw.WriteLine("  Ready processes queue: ");
            writteReadyProcess(processReadyList, sw);
            sw.WriteLine("\n  Blocked processes: ");
            writteReadyProcess(processBlockList, sw);
            sw.WriteLine("\nEvents: ");
            sw.WriteLine("The next process will be created in " + nextProcessTime);
            printOtterEvents(cpuStatus);
            sw.Close();
        }

        public void writteText(string text) {
            sw = new StreamWriter(PATH_FILE, true);
            sw.WriteLine(text);
            sw.Close();
        }

        public void closeDocument() {
            sw.Close();
        }

        public void writteEvents(List<string> actualEvents) {
            foreach (var item in actualEvents)
            {
                sw.WriteLine(item);
            }
        }

        public void printEvents(Process actualProcess) {
            if (actualProcess == null ) {
                sw.WriteLine("Process 1 was created.");
                sw.WriteLine("Process 1 was assigned to CPU.");
            } else if (processCreated != actualProcess.getIdProcess()) {
                sw.WriteLine("Process " + processCreated + " was created.");
                sw.WriteLine("Process " + processAssigned + " was assigned to CPU.");
                processCreated = actualProcess.getIdProcess();
                processAssigned = actualProcess.getIdProcess();
            }
        }

        public void printOtterEvents(Status cpuStatus)
        {
            if (cpuStatus == Status.IDLE)
            {
                sw.WriteLine("CPU is IDLE!");
            }
        }

        public void verifyActualProcess(Process actualProcess, Status cpuStatus, int clock, StreamWriter sw) {
            if (actualProcess == null)
            {
                sw.WriteLine("Clock: 0");
                sw.WriteLine("CPU: ");
                sw.WriteLine("  -> Status: IDLE");
                sw.WriteLine("  -> Process: None \n");
            }
            else
            {
                sw.WriteLine("Clock: " + clock);
                sw.WriteLine("CPU: ");
                sw.WriteLine("  -> Status: " + cpuStatus);
                sw.WriteLine("  -> Process: " + "[ID: " + actualProcess.getIdProcess() + ", Life Time:" + actualProcess.getLifeTime()
                + "/20, Next IO: " + actualProcess.getNextIo() + "/4, IO: " + actualProcess.getIO() + "/3, Status: " +
                actualProcess.getStatus() + ", Quantum: " + actualProcess.getQuantum() + "] \n");
            }
        }

        private static void writteReadyProcess(List<Process> listProcess, StreamWriter sw) {
            if (listProcess.Count != 0)
            {
                foreach (Process process in listProcess)
                {
                    sw.WriteLine("  -> Process: " + "[ID: " + process.getIdProcess() + ", Life Time:" + process.getLifeTime()
                    + "/20, Next IO: " + process.getNextIo() + "/4, IO: " + process.getIO() + "/1, Status: " +
                    process.getStatus() + ", Quantum: " + process.getQuantum() + "] \n");
                }
            } else
            {
                sw.WriteLine("  -> Process: None");
            }
        }

        private static void writteEvents(List<Process> listProcess, StreamWriter sw)
        {
            foreach (Process process in listProcess)
            {
                sw.WriteLine("  -> Process: " + "[ID: " + process.getIdProcess() + ", Life Time:" + process.getLifeTime()
                + "/ 20, Next IO: " + process.getNextIo() + "/4, IO: " + process.getIO() + "/ 1, Status: " +
                process.getStatus() + ", Quantum: " + process.getQuantum() + "] \n");
                sw.WriteLine("Ready processes queue: ");
            }
        }
    }

}
