using System;
using System.Linq;

namespace TurnWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку и нажмите Enter:");
            string enteringString = Console.ReadLine();

            Console.WriteLine($"Изначальная строка - {enteringString}");
            Console.Write($"Перевернутая строка - ");
            for (int i = enteringString.Length - 1; i >= 0; i--)
            {
                Console.Write(enteringString[i]);
            }            
            Console.ReadKey();
        }
    }
}
