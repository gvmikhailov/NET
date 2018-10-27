using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRecources
{
    class Employee
    {
        public string Name { get; set; }

        internal Employee (string name)
        {
            Name = name;
        }

        internal virtual void PrintInfo()
        {
            Console.WriteLine("Работник предприятия - {0}", Name);
        }
    }
}
