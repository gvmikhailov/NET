using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(10, 10, 10);
            Circle circle2 = new Circle(20, 20, 10);
            Circle circle3 = new Circle(10, 10, 10);
            Console.WriteLine(circle1.GetHashCode());
            Console.WriteLine(circle2.GetHashCode());
            Console.WriteLine(circle3.GetHashCode());
            Console.WriteLine(circle1.Equals(circle2));
            Console.WriteLine(circle2.Equals(circle3));
            Console.WriteLine(circle1.Equals(circle3));
        }
    }
}
