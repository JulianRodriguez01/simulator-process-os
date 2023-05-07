using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectProcess.models
{
    public enum Status
    {
        IDLE, 
        BUSY,
        running, 
        ready, 
        blocked, 
        finish
    }
}
