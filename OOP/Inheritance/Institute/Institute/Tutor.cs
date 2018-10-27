using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute
{
    class Tutor : Human
    {
        public string Position { get; set; }
        public string Cathedra { get; set; }

        internal Tutor (string name, DateTime birthDate, string position, string cathedra) : base (name, birthDate)
        {
            Position = position;
            Cathedra = cathedra;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Преподаватель: ФИО - {0},\nДата Рождения - {1}\nРаботает на кафедре {2},\nв должности - {3}", Name, BirthDate.ToShortDateString(), Cathedra, Position);
            Console.WriteLine();
        }
    }
}
