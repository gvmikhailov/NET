using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampInverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lampCounter = rnd.Next(1, 1001);
            Console.WriteLine("Количество ламп - {0}", lampCounter);
            int lineInverse = rnd.Next(1, 101);
            Console.WriteLine("Количество инверсий - {0}", lineInverse);
            int[] numberOfLineInverse = new int[lineInverse];
            Console.WriteLine("Периоды инверсии:");
            for (int i = 0; i < numberOfLineInverse.Length; i++)
            {
                numberOfLineInverse[i] = rnd.Next(1, 11);
                Console.Write(numberOfLineInverse[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Включенных ламп после {0} инверсий - {1}", lineInverse, TurnOnLamps(lampCounter, numberOfLineInverse));
        }
        static int TurnOnLamps (int lampCounter, int[] numberOfLineInverse)
        {
            int turnOnLamps = 0;
            int[] turnOnLampsArray = new int[lampCounter];
            for (int k = 0; k < turnOnLampsArray.Length; k++)
            {
                turnOnLampsArray[k] = 0;
            }
            for (int j = 1; j <= turnOnLampsArray.Length; j++)
            {
                for (int k = 0; k < numberOfLineInverse.Length; k++)
                {
                    if (turnOnLampsArray[j-1] == 0 && j%numberOfLineInverse[k] == 0)
                    {
                        turnOnLampsArray[j-1] = 1;
                    }
                    else if (turnOnLampsArray[j-1] == 1 && j % numberOfLineInverse[k] == 0)
                    {
                        turnOnLampsArray[j-1] = 0;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            foreach (int k in turnOnLampsArray)
            {
                if (k == 1)
                {
                    turnOnLamps++; 
                }
                Console.Write(k + ", ");
            }
            Console.WriteLine();            
            return turnOnLamps;
        }
    }
}
