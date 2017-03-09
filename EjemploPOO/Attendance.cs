using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Attendance
    {
        private List<String> workDays = new List<string>();

        public void addWorkDay(Worker worker)
        {
            workDays.Add(worker.getName());
        }
    }
}
