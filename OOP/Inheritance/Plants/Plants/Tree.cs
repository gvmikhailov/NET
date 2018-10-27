using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    class Tree : Plant
    {
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    _age = Program.rnd.Next(0, 101);
                    Console.WriteLine("Возраст дерева не может быть отрицательным или больше 100 лет - установлено {0} лет", _age);
                }
                else
                {
                    _age = value;
                }
            }
        }

        internal Tree (string name, string species, int age) : base (name, species)
        {
            Age = age;
        }

        internal new void PrintPlantInfo()
        {
            Console.WriteLine("Дерево {0} вида {1}, c возрастом {2} {3}", Name, Species, Age, GetStringAge(Age));
        }

        private string GetStringAge(int age)
        {
            string stringAge = "лет";
            if (age % 10 == 1) stringAge = "год";
            if (age % 10 >= 2 && age % 10 <= 4) stringAge = "года";
            if (age % 100 >= 11 & age % 100 <= 20) stringAge = "лет";
            return stringAge;
        }
    }
}
