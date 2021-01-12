using System;

namespace SummNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            for (int i = 0; i < args.Length; i++)
            {
                int number;
                bool result = Int32.TryParse(args[i], out number); 
                if (result)
                {
                    summ += number;
                }
            }

            Console.WriteLine($"Сумма поданых на вход элементов - {summ}");
        }
    }
}
