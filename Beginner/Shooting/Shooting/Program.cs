using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1409

namespace Shooting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int firstBandidoCannons = rnd.Next(1, 6);
            int secondBandidoCanons = rnd.Next(1, 6);
            Console.WriteLine("Первый бандит прострелил {0} банок, второй прострелил {1} банок", firstBandidoCannons, secondBandidoCanons);
            int allCannons = (firstBandidoCannons + secondBandidoCanons) - 1;
            Console.WriteLine("Первый бандит не прострелил: " + FirstNotShotThrough(allCannons, firstBandidoCannons) + " банок");
            Console.WriteLine("Второй бандит не прострелил: " + SecondNotShotThrough(allCannons, secondBandidoCanons) + " банок");
        }
        static int FirstNotShotThrough(int allCannons, int firstBandidoCannons)
        {
            int firstNotShotThrough = allCannons - firstBandidoCannons;
            return firstNotShotThrough;
        }
        static int SecondNotShotThrough(int allCannons, int secondBandidoCannons)
        {
            int secondNotShotThrough = allCannons - secondBandidoCannons;
            return secondNotShotThrough;
        }
    }
}
