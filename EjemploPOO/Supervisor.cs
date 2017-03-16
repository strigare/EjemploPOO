using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Supervisor : Worker
    {
        private List<Worker> supervisedWorkers = new List<Worker>();

        public Supervisor(string name, int salary) : base(name, salary)
        {
        }

        public void addSupervisedWorker(Worker worker)
        {
            this.supervisedWorkers.Add(worker);
        }

        public override void Work()
        {
            base.Work();

            foreach (Worker worker in supervisedWorkers)
            {
                Console.WriteLine("\t\tSuperviso como trabaja " + worker.getName() + " y tomo cafe");
            }
        }
    }
}
