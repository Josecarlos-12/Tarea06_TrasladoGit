using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Utensilios : Program
    {
        public string name;
        public string tipo;

        public Utensilios()
        { }
        public Utensilios(string name, string tipo)
        {
            this.name = name;
            this.tipo = tipo;

        }

        public Utensilios(string name, int tipo1)
        {
            this.name = name;
        }
    }
}
