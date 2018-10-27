using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRecources
{
    class Worker : Employee
    {
        public string Specialty { get; set; }
        public string WorkShop { get; set; }

        internal Worker (string name, string specialty, string workshop) : base (name)
        {
            Specialty = specialty;
            WorkShop = workshop;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Рабочий {0} работает в {1} цехе по специальности {2}", Name, WorkShop, Specialty);
        }
    }
}
