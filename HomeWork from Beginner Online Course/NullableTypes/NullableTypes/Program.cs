using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Alice", "Brokovich", null);
            Human human2 = new Human("John", "Smith", 0);
            Human human3 = new Human("Ivan", "Ivanov", 2);
            Human human4 = new Human("Petr", "Boyko", 10);
            human1.ChildrenCount();
            human2.ChildrenCount();
            human3.ChildrenCount();
            human4.ChildrenCount();
        }
    }
}
