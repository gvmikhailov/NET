using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] femaleNames = {"Мария", "Анна", "Валентина", "Лидия", "Александра", "Евгения", "Ирина",
            "Софья", "Людмила", "Ксения", "Виктория", "Марина", "Инна", "Светлана", "Яна", "Татьяна", "Ева"};
            List<Human> people = new List<Human>();
            for (int i = 0; i < rnd.Next(0, 101); i++)
            {
                people.Add(new Human(femaleNames[rnd.Next(0, femaleNames.Length)], rnd.Next(10, 51)));
            }
            people.OrderBy(u => u.Age);
            Human hum = BinarySearch(people, rnd.Next(10, 51));
            Console.WriteLine($"{hum.Name} - {hum.Age}");
            Console.ReadKey();
        }

        static Human BinarySearch(List<Human> humans, int age)
        {
            int min = 0;                    // 1
            int max = humans.Count - 1;     // 1
            while (min <= max)              // (N:2 + 1*1 + 1*1 + 1*1) => (N:2 + 1) => (N:4 + 1 + 1) ... (N:2^k)+1+1+1.....+1, где 2^k = n => k = logN 
            {
                int mid = (min + max) / 2;  
                if (age == humans[mid].Age)
                {
                    return humans[mid];
                }
                else if (age < humans[mid].Age)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return null;                    // 1
            // 1+ 1 + logN + 1 => сложность O(logN)
        }
    }
}
