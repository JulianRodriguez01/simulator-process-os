using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectProcess.models
{
    internal class Events {

        private string description;
        private int time;

        public Events(string description, int time) { 
            this.description = description;
            this.time = time;
        }
    }
}
