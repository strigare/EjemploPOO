using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();

            Worker ignacio = new Worker("Ignacio", 10000);
            workers.Add(ignacio);
            Worker jose = new Worker("Jose", 10000);
            workers.Add(jose);

            Supervisor andres = new ModernSupervisor("Andres", 1000000);
            andres.addSupervisedWorker(ignacio);
            workers.Add(andres);

            Supervisor tomas = new OldFashionedSupervisor("Andres", 1000000);
            tomas.addSupervisedWorker(jose);
            workers.Add(tomas);

            Company magnet = new Company("Magnet", workers);

            magnet.Work();
            magnet.Work(4);

            Console.ReadLine();
        }
    }
}
