using System;
using FigureLibrary;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure circle = new Circle(10);
            Console.WriteLine(circle.GetArea());
            IFigure circle1 = new Circle(-10);
            Console.WriteLine(circle1.GetArea());

            IFigure triangle = new Triangle(2, 3, 4);
            Console.WriteLine(triangle.GetArea());
            IFigure triangle1 = new Triangle(-5, 8, 11);
            Console.WriteLine(triangle1.GetArea());
            IFigure triangle2 = new Triangle(2, 3, 4.6);
            Console.WriteLine(triangle2.GetArea());
        }
    }
}
