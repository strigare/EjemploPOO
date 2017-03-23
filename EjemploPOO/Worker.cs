using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Worker : IWorkable
    {
        private string name;
        private int salary;

        public Worker(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public virtual void Work()
        {
            Console.WriteLine("\tHola, soy " + this.name + " y estoy trabajando");
        }
    }
}
