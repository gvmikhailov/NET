using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGU
{
    class Subgroups : Groups
    {
        private int _numbersOfStudents;

        public string SubgroupNumber { get; set; }
        public int NumbersOfStudents
        {
            get
            {
                return _numbersOfStudents;
            }
            set
            {
                if (value < 3 || value > 6)
                {
                    Console.WriteLine("Недопустимое количество студентов в подгруппе - установлено значение 4");
                    _numbersOfStudents = 4;
                }
                else
                {
                    _numbersOfStudents = value;                  
                }
            }
        }

        internal Subgroups (string address, string number, string praepostor, int grade, int numbersOfStudents, string subgroupNumber) : base (address, number, praepostor, grade)
        {
            SubgroupNumber = subgroupNumber;
            NumbersOfStudents = numbersOfStudents;
        }

        internal new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Подгруппа - {0}\nКоличество студентов - {1}", SubgroupNumber, NumbersOfStudents);
        }
    }
}
