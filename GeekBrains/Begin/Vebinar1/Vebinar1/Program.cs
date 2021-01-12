using System;

namespace Vebinar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте,\nвведите, пожалуйста свое имя и нажмите Enter.");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToLongDateString()}");
            Console.ReadKey();
        }
    }
}
