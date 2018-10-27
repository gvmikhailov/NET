using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int radius = rnd.Next(1, 101);
            var roundProperties = SquareAndLenghtCounter(radius);
            Console.WriteLine("Радиус - {2}. Длина окружности - {0}. Площадь круга - {1}.", roundProperties.Item2, roundProperties.Item1, radius);
        }
        static (double,double) SquareAndLenghtCounter (int radius)
        {
            double square = Math.Round(Math.PI * radius * radius,2);
            double lenght = Math.Round(2 * Math.PI * radius,2);
            return (square, lenght);
        }
    }
}
