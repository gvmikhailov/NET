using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int workerNumbers = rnd.Next(1, 20);
            Console.WriteLine($"Создано {workerNumbers} рабочих");
            Employee[] worker = new Employee[workerNumbers];
            for (int i = 0; i < worker.Length; i++)
            {
                int id = rnd.Next(1, 1001);
                double salary = rnd.Next(10000, 100000) + rnd.NextDouble();
                worker[i] = new Employee(id, salary);
            }
            foreach (Employee m in worker)
            {
                m.PrintInfo();                    ;
            }
        }
    }
}
