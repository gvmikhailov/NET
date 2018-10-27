using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRecources
{
    class Engineer : Employee
    {
        public string Qualification { get; set; }
        public string Subdivision { get; set; }

        internal Engineer (string name, string qualification, string subdivision) : base (name)
        {
            Qualification = qualification;
            Subdivision = subdivision;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Инженер {0} с квалификацией {1} работает в подразделении - {2}", Name, Qualification, Subdivision);
        }
    }
}
