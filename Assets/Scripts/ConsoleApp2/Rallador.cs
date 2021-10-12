using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Rallador : Utensilios
    {

        public string funcion;

        public Rallador(string name, int tipo, string funcion) : base(name, tipo) 
        {

            this.funcion = funcion;
        
        }
    }

}
