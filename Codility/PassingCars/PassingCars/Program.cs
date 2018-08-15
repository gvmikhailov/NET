using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = rnd.Next(2, 1001);
            int[] cars = new int[length];
            for (int i = 0; i < length; i++)
            {
                cars[i] = rnd.Next(0, 2);
            }
            int west = 0;
            int east = 0;
            foreach (int m in cars)
            {
                if (m==0)
                {
                    east++;
                }
                else
                {
                    west++;
                }
            }
            int pairsOfPassingCars = GetPassingCar(cars);
            Console.WriteLine("Всего ехало {0} автомобилей, из них на запад - {1}, на восток - {2}\nВстретившихся пар - {3}", length, west, east, pairsOfPassingCars);
        }

        static int GetPassingCar(int[] cars)
        {
            int carToEast = 0;
            int passingPair = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == 1)
                {
                    passingPair += carToEast;
                }
                else
                {
                    carToEast++;
                }
            }
            if (passingPair > 1000000000 || passingPair < 0)
            {
                return -1;
            }
            else
            {
                return passingPair;
            }
        }
    }
}