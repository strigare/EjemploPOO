using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Machine : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("\tSoy una maquina y estoy trabajando");
        }
    }
}
