using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1617

namespace Sliders
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pairOfWheelsCounter = rnd.Next(1, 150);
            Console.WriteLine("Количество имеющихся колесных пар - {0}", pairOfWheelsCounter);
            List<int> pairOfWheelsDiameters = new List<int>();
            for (int i = 0; i < pairOfWheelsCounter; i++)
            {
                pairOfWheelsDiameters.Add(rnd.Next(695, 701));
                Console.WriteLine(pairOfWheelsDiameters[i]);
            }
            Console.WriteLine();
            GetRepairedVagons(pairOfWheelsDiameters);
        }
        static void GetRepairedVagons(List<int> pairOfWheelsDiameters)
        {
            List<int> wagonCounterList = new List<int>();
            foreach (int val in pairOfWheelsDiameters.Distinct())
            {
                int wagoncounter = 0;
                int count = pairOfWheelsDiameters.Count(x => x == val);
                wagoncounter = count / 4;
                wagonCounterList.Add(wagoncounter);
                Console.WriteLine("Колеса с диаметром {0} - {1} вагонов", val, wagoncounter);
            }
            int allWagons = wagonCounterList.Sum();
            Console.WriteLine("Всего {0} вагонов", allWagons);
        }
    }
}
