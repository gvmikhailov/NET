using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/8/2013_04_15_arifmeticheskie_i_logicheskie_operacii_v_si-sharp.html

namespace HomeWorkArithmeticalOperationsMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double cathetus1 = rnd.Next(1, 20);
            double cathetus2 = rnd.Next(1, 20);
            Console.WriteLine("При катетах {0} и {1} площать прямоугольного треугольника будет S = {2}", cathetus1, cathetus2, TriangleArea(cathetus1, cathetus2));
            Console.WriteLine("При катетах {0} и {1} гипотенуза прямоугольного треугольника по теореме Пифагора будет с = {2}", cathetus1, cathetus2, HypotenuseByPiphagor(cathetus1, cathetus2));
            Console.WriteLine("При катетах {0} и {1} гипотенуза прямоугольного треугольника по теореме косинусов будет с = {2}", cathetus1, cathetus2, HypotenuseByCosinusTheoreme(cathetus1, cathetus2));
        }
        static double TriangleArea(double cathetus1, double cathetus2)
        {
            double triangleArea = 0;
            triangleArea = Math.Round((cathetus1 * cathetus2) / 2, 2);
            return triangleArea;
        }
        static double HypotenuseByPiphagor(double cathetus1, double cathetus2)
        {
            double hypotenuse = 0;
            hypotenuse = Math.Round(Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2)), 2);
            return hypotenuse;
        }
        static double HypotenuseByCosinusTheoreme(double cathetus1, double cathetus2)
        {
            double hypotenuse = 0;
            hypotenuse = Math.Round(Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2) - (2 * (cathetus1 * cathetus2)) * Math.Cos(90 * Math.PI / 180)), 2);
            return hypotenuse;
        }
    }
}
