using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute
{
    class Enrollee : Human
    {

        private int _score;
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение полученного абиткриентом балла не может быть меньше 0, установлено 0 баллов");
                    Console.WriteLine();
                    _score = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine("Значение полученного абиткриентом балла не может быть больше 100, установлено 100 баллов");
                    Console.WriteLine();
                    _score = 100;
                }
                else
                {
                    _score = value;
                }
            }
        }

        internal Enrollee(string name, DateTime birthDate, int score) : base (name, birthDate)
        {
            Score = score;
        }

        internal string GetStringScores(int value)
        {
            string stringScores = "баллов";
            if (value % 10 == 1) stringScores = "балл";
            if (value % 10 >= 2 && value % 10 <= 4) stringScores = "балла";
            if (value % 100 >= 11 & value % 100 <= 20) stringScores = "баллов";
            return stringScores;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Абитуриент: ФИО - {0},\nДата Рождения - {1}\nНабрал {2} {3}", Name, BirthDate.ToShortDateString(), Score, GetStringScores(Score));
            Console.WriteLine();
        }
    }
}
