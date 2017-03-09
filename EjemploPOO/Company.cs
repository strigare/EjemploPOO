using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Company
    {
        private String name;
        private List<Worker> workers;
        private Attendance attendance = new Attendance();

        public Company(String name, List<Worker> workers)
        {
            this.name = name;
            this.workers = workers;
        }

        public Company()
        {
            this.name = "Nombre Generico";
            workers = new List<Worker>();
        }

        public void Work()
        {
            Console.WriteLine("Soy la empresa " + this.name + " y estoy trabajando");
            sendWorkersToWork();
        }

        public void Work(int hours)
        {
            Console.WriteLine("Soy la empresa " + this.name + " y estoy trabajando " + hours
                + " horas");
            sendWorkersToWork();
        }

        private void sendWorkersToWork()
        {
            foreach (Worker worker in workers)
            {
                worker.Work();
                attendance.addWorkDay(worker);
            }
        }
    }
}
