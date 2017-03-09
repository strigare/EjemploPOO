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

            Company magnet = new Company("Magnet", workers);

            magnet.Work();
            magnet.Work(4);

            Console.ReadLine();
        }
    }
}
