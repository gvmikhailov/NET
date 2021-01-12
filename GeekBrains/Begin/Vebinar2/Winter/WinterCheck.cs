using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter
{
    public class WinterCheck
    {
        public static void Main(string[] args)
        {
            double minTemp, maxTemp;
            int monthNumber;
            int[] winterMonthes = { 1, 2, 12 };
            if (Double.TryParse(args[0], out minTemp) == true && Double.TryParse(args[1], out maxTemp) == true  && Int32.TryParse(args[2], out monthNumber) == true)
            {
                if ((maxTemp + minTemp) / 2 > 0 && monthNumber > 0 && monthNumber < 13 && winterMonthes.Contains(monthNumber))
                {
                    Console.WriteLine("Дождливая зима!");
                }
            }
            else
            {
                Console.WriteLine("Одна, обе температуры или номер месяца не являются числом!");
            }
        }
    }
}
