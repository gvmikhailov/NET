using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Метод №1
            Random rnd = new Random();
            int number = rnd.Next(100, 1000);
            Console.WriteLine("Число - " + number);
            string numberString = number.ToString();
            int multiplication = int.Parse(numberString.Substring(0, 1)) * int.Parse(numberString.Substring(1, 1)) * int.Parse(numberString.Substring(2, 1));
            Console.WriteLine("Произведение трех составляющих число цифр - " + multiplication);
            // Метод №2
            int firstDigit = number / 100;
            // Console.WriteLine(firstDigit);
            int partOfSecondDigit = number - firstDigit*100;
            if (partOfSecondDigit >= 0 && partOfSecondDigit < 10)
            {
                multiplication = 0;
                Console.WriteLine("Произведение трех составляющих число цифр - " + multiplication);
            }
            else
            {
                int secondDigit = partOfSecondDigit / 10;
                // Console.WriteLine(secondDigit);
                int thirdDigit = partOfSecondDigit - secondDigit*10;
                // Console.WriteLine(thirdDigit);
                multiplication = firstDigit * secondDigit * thirdDigit;
                Console.WriteLine("Произведение трех составляющих число цифр - " + multiplication);
            }
        }
    }
}
