using System;

namespace BinarySearch
{
    class Human
    {
        private int _age;

        public string Name { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 40;
                    Console.WriteLine("Возраст не может быть меньше 0, установлено значение 40");
                }
                else if (value > 123)
                {
                    _age = 40;
                    Console.WriteLine("Самый старый долгожитель - 124 года, установлено значение 40");
                }
                else
                {
                    _age = value;
                }
            }
        }

        internal Human(string name, int age)
        {
            Name = Name;
            Age = age;
        }
    }
}
