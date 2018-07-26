using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Программа находит число пи до n-й цифры после запятой

namespace Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lenght = rnd.Next(2, 29);            
            if (lenght <= 14)
            {
                GetPiFromMath(lenght);
            }
            else
            {
                Console.WriteLine("Внимание! необходимо подождать несколько минут!");
                GetPiLeibnitz(lenght);
            }
        }

        static void GetPiFromMath(int lenght)
        {
            Console.WriteLine("Число Пи до {0} знаков после запятой:", lenght);
            Console.WriteLine(Math.Round(Math.PI, lenght));
        }

        static void GetPiLeibnitz(int lenght)
        {
            decimal pi = 0;
            ulong m = 1;
            int znak = 1;
            for (ulong i = 1; i <= 1000000000; i++)
            {
                pi += (decimal)znak / m;
                m += 2;
                znak *= -1;
            }
            decimal result = Decimal.Round((pi * 4), lenght);
            Console.Clear();
            Console.WriteLine("Число Пи до {0} знаков после запятой:", lenght);
            Console.WriteLine(result);
        }
    }
}
