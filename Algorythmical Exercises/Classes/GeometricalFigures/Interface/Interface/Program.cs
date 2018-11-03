using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Введите радиус окружности: ");
            string input = Console.ReadLine();
            bool resultOfParse = double.TryParse(input, out radius);
            if (resultOfParse == true && radius >=0 && radius <= double.MaxValue)
            {
                IFigure circle = new Circle(radius);
                Console.WriteLine($"Площадь окружности с радиусом {radius} равна {circle.GetArea()}");
            }
            else
            {
                Console.WriteLine("Неверно задан радиус!");
            }
            Console.ReadKey();

            // The same code for check triangle or another figure sides
        }
    }
}
