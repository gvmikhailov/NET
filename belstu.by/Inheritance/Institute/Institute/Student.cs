using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute
{
    class Student : Human
    {
        private int _course;

        public string Group { get; set; }
        public string Faculty { get; set; }
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Значение курса не может быть меньше 1, установлено значение 1");
                    _course = 1;
                }
                else if (value > 6)
                {
                    Console.WriteLine("Значение курса не может быть больше 6, установлено значение 6");
                    _course = 6;
                }
                else
                {
                    _course = value;
                }
            }
        }

        internal Student (string name, DateTime birthDate, string faculty, int course, string group) : base (name, birthDate)
        {
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Студент: ФИО - {0},\nДата Рождения - {1}\nОбучается на факультете {2}\nНа {3} курсе, в группе {4}{3}", Name, BirthDate.ToShortDateString(), Faculty, Course, Group);
            Console.WriteLine();
        }
    }
}
