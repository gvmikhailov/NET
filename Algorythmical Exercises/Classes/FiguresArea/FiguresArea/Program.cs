using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;

namespace FiguresArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure circle1 = new Circle(15);
            Console.WriteLine(circle1.GetArea());

            Figure triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine(triangle1.GetArea());
        }
    }
}
