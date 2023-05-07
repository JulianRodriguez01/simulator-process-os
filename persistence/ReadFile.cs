using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectProcess.persistence
{
    public class ReadFile
    {
        public static string PATH_FILE = "../../../output/register.txt";

        public String getTextFile()
        {
            string[] lines = System.IO.File.ReadAllLines(PATH_FILE);
            string result = "";
            foreach (string line in lines)
            {
                result += line + "\n";
            }
            return result;
        }
    }
}
