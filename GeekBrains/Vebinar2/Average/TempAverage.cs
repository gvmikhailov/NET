using System;

namespace Average
{
    public class TempAverage
    {
        public static void Main(string[] args)
        {
            double minTemp, maxTemp;
            if(Double.TryParse(args[0], out minTemp) == true && Double.TryParse(args[1], out maxTemp) == true)
            {
                Console.WriteLine($"Среднесуточная температура: {(maxTemp + minTemp) / 2}");
            }
            else
            {
                Console.WriteLine("Одна или обе температуры не являются числом!");
            }
        }
    }
}
