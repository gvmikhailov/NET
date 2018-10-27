using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/48/2014_12_21_struktury_v_si-sharp.html

namespace AverageCircle
{
    class Program
    {
        public struct Circle
        {
            public static void FindingRadiusCloseToAverage(double [] radiuses)
            {
                List<double> delta = new List<double>();
                double radiusAverage = Math.Round(radiuses.Sum()/radiuses.Length, 2);
                Console.WriteLine("Среднее значение радиусов - {0}", radiusAverage);
                for (int k = 0; k < radiuses.Length; k++)
                {
                    delta.Add(Math.Abs(radiuses[k] - radiusAverage));
                }
                double minimalAverage = delta.Min();
                int minimalAverageIndex = delta.IndexOf(minimalAverage);
                double radiusCloseToAverage = radiuses[minimalAverageIndex];
                Console.WriteLine("Радиус, наиболее близкий к среднему значению - {0}", radiusCloseToAverage);
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arrayLenght = rnd.Next(1, 100);
            double[] radiuses = new double[arrayLenght];
            for (int i = 0; i < radiuses.Length; i++)
            {
                radiuses[i] = Math.Round(rnd.NextDouble() + rnd.Next(0,101), 2);
                Console.Write(radiuses[i] + ", ");
            }            
            Console.WriteLine();
            Circle.FindingRadiusCloseToAverage(radiuses);
        }
    }
}
