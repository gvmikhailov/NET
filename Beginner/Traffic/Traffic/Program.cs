using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1787

namespace Traffic
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int succeededCars = rand.Next(1, 101);
            Console.WriteLine("Количество машин, успевающих повернуть на «МЕГУ» в течение минуты - {0}", succeededCars);
            int time = rand.Next(1, 101);
            Console.WriteLine("Количество минут, прошедших с начала наблюдений - {0}", time);
            int[] carsCounter = new int[time];
            for (int i = 0; i < carsCounter.Length; i++)
            {
                carsCounter[i] = rand.Next(0, 20);
                Console.Write(carsCounter[i] + ", ");
            }
            Console.WriteLine();
            int summCarsTime = carsCounter.Sum();
            int succeededCarsPassed = succeededCars * time;
            int carsInTraffic = summCarsTime - succeededCarsPassed;
            if (carsInTraffic < 0)
            {
                carsInTraffic = 0;
            }
            Console.WriteLine("Машин в пробке - " + carsInTraffic);
        }
    }
}
