using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер номер члена последовательности Фибоначчи и нажмите Enter:");
            string num = Console.ReadLine();
            int number;
            if (Int32.TryParse(num, out number) == true)
            {
                int fbNumber = GetFibonachi(number);
                Console.WriteLine($"для указанного члена число Фибоначчи = {fbNumber}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом!");
                Console.ReadKey();
            }
        }

        static int GetFibonachi(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return GetFibonachi(number - 1) + GetFibonachi(number - 2);
            }
        }
    }
}
