using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1991

namespace SwampBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int partsOfArmies = rnd.Next(1, 10001);
            Console.WriteLine("Количество блоков дроидов и количество частей армии гунганов - {0}", partsOfArmies);
            int numberOfDroids = rnd.Next(1, 10001);
            Console.WriteLine("Количество дроидов в каждом блоке - {0}", numberOfDroids);
            int[] bumbum = new int[partsOfArmies];
            int leftoverBumBum = 0;
            int survivorDroids = 0;
            for (int i = 0; i < bumbum.Length; i++)
            {
                bumbum[i] = rnd.Next(0, numberOfDroids + numberOfDroids);
                Console.Write(bumbum[i] + ", ");
                if (bumbum[i] >= numberOfDroids)
                {
                    leftoverBumBum = (bumbum[i] - numberOfDroids) + leftoverBumBum;
                }
                if (bumbum[i] < numberOfDroids)
                {
                    survivorDroids = (numberOfDroids - bumbum[i]) + survivorDroids;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Оставшиеся БумБумы - " + leftoverBumBum + " штук");
            Console.WriteLine("Выжившие Дроиды - " + survivorDroids + " единиц");
        }
    }
}
