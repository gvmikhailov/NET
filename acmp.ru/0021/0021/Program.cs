using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> listOfSalary = new List<int>();
            Console.Write("Зарплаты: ");
            for (int i = 0; i < 3; i++)
            {
                listOfSalary.Add(rnd.Next(10, 100000));
                Console.Write(listOfSalary[i] + ", ");
            }
            Console.WriteLine("Разница между самой высокой и самой низкой зарплатой - {0}", GetDifferenceBetweenSalary(listOfSalary));
        }
        static int GetDifferenceBetweenSalary (List <int> listOfSalary)
        {
            int differenceBetweenSalary = listOfSalary.Max() - listOfSalary.Min();
            return differenceBetweenSalary;
        }
    }
}
