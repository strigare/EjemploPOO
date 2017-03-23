using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class ModernSupervisor : Supervisor
    {
        public ModernSupervisor(string name, int salary) : base(name, salary)
        {
        }

        public override void FileReport()
        {
            Console.WriteLine("\t\tEstoy escribiendo un reporte en computador");
        }
    }
}
