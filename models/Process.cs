using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectProcess.models
{
    public class Process
    {
        private int idProcess;
        private int lifeTime;
        private int nextIo;
        private int IO;
        private int quantum;
        private Status status;

        public Process(int idProcess, int lifeTime, int nextIo, int IO, int quantum) { 
            this.idProcess = idProcess;
            this.lifeTime = lifeTime;
            this.nextIo = nextIo;
            this.IO = IO;
            this.quantum = quantum; 
        }

        public int getIdProcess() { return idProcess;}

        public int getLifeTime() { return lifeTime;}

        public void setLifeTime(int lifeTime) { this.lifeTime = lifeTime;}

        public int getNextIo() { return nextIo;}

        public void setNextIo(int nextIo) { this.nextIo = nextIo; }

        public int getIO() { return IO;}

        public void setIO(int IO) { this.IO = IO; }

        public int getQuantum() { return quantum;}

        public void setQuantum(int quantum) { this.quantum = quantum; }

        public Status  getStatus() { return status;}

        public void setStatus(Status status) { this.status = status; }
    }
}
