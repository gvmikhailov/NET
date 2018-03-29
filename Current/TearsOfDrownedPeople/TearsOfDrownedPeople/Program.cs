using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearsOfDrownedPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int skinsCounter = rnd.Next(1, 100);
            List <int> listCounter = new List <int>();
            for (int i = 0; i < skinsCounter; i++)
            {
                listCounter.Add(rnd.Next(1, 21));
            }
            listCounter.Sort();
            listCounter.Reverse();
            //foreach (int item in listCounter)
            // {
            //     Console.Write(item + ", ");
            // }
            int firstList = listCounter.First();
            int summLists = listCounter.Sum();
            int lastList = listCounter.Last();
            // Console.WriteLine();
            // Console.Write(firstList + " " + summLists + " " + lastList);
            int bookDepth = firstList + summLists + lastList;
            Console.WriteLine("Толщина книги должна быть не меньше {0} страниц", bookDepth); 
         }
    }
}
