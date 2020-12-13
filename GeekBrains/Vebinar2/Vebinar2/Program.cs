using System;

namespace Vebinar2
{
    class Program
    {
        static void Main()
        {
            string[] input = new string[2];
            Console.WriteLine("Введите минимальную температуру и нажмите Enter:");
            input[0] = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру и нажмите Enter:");
            input[1] = Console.ReadLine();
            Average.TempAverage.Main(input);
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();

            string[] month = new string[1];
            Console.WriteLine("Введите месяц года и нажмите Enter:");
            month[0] = Console.ReadLine();
            Month.YearMonth.Main(month);
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();

            string [] number = new string[1];
            Console.WriteLine("Введите любое целое число и нажмите Enter:");
            number[0] = Console.ReadLine();
            Even.EvenCheck.Main(number);
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();

            string[] data = { input[0], input[1], month[0] };
            Winter.WinterCheck.Main(data);
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
