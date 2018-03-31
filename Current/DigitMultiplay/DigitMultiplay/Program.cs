using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Результат умножения трех цифр трехзначного числа

namespace DigitMultiplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplayDigit;
            Random rnd = new Random();
            int tripleDigit = rnd.Next(100, 1000);
            Console.WriteLine("Сгенерированное число - " + tripleDigit);
            int firstDigit = tripleDigit / 100;
            int intermediateValue = tripleDigit % 100;
            if (intermediateValue >=0 && intermediateValue <= 9)
            {
                multiplayDigit = 0;
                Console.WriteLine("Результат умножения трёх цифр числа - " + multiplayDigit);
            }
            else
            {
                int secondDigit = intermediateValue / 10;
                int thirdDigit = intermediateValue % 10;
                multiplayDigit = firstDigit * secondDigit * thirdDigit;
                Console.WriteLine("Результат умножения трёх цифр числа - " + multiplayDigit);
            }
            Console.ReadKey();
        }
    }
}
