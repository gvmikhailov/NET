using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? NumberOfChildren { get; set; }
        public Human (string name, string surname, int? numberOfChildren)
        {
            Name = name;
            Surname = surname;
            NumberOfChildren = numberOfChildren;
        }
        public void ChildrenCount()
        {
            if (NumberOfChildren == 0)
            {
                Console.WriteLine("У человека по имени {0} {1} нет детей", Name, Surname);
            }
            else if (NumberOfChildren == null)
            {
                Console.WriteLine("У человека по имени {0} {1} неизвестное количество детей", Name, Surname);
            }
            else
            {
                Console.WriteLine("У человека по имени {0} {1} - {2} детей", Name, Surname, NumberOfChildren);
            }
        }
    }
}
