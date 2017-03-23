using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class OldFashionedSupervisor : Supervisor
    {
        public OldFashionedSupervisor(string name, int salary) : base(name, salary)
        {
        }

        public override void FileReport()
        {
            Console.WriteLine("\t\tEstoy escribiendo un reporte en papel");
        }
    }
}
