using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGU
{
    class Groups : bgtu
    {
        private int _grade;

        public string Number { get; set; }
        public string Praepostor { get; set; }

        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    Console.WriteLine("Курс не может быть меньше первого или больше 5, установлено значение 1");
                    _grade = 1;
                }
                else
                {
                    _grade = value;
                }
            }
        }

        internal Groups(string address, string number, string praepostor, int grade) : base  (address)
        {
            Number = number;
            Praepostor = praepostor;
            Grade = grade;
        }

        internal new void PrintInfo()
        {
            Console.WriteLine("Группа: {0};\nСтароста: {1};\nКурс: {2};", Number, Praepostor, Grade);
        }
    }
}
