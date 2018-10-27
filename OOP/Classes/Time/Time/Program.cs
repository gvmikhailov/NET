using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal enum Hours
    {
        часов = 1,
        час,
        часа
    }

    internal enum Minutes
    {
        минут = 1,
        минута,
        минуты
    }

    internal enum Seconds
    {
        секунд = 1,
        секунда,
        секунды
    }

    class Program
    {
        static void Main(string[] args)
        {
            Times time1 = new Times(8, 21, 2);
            time1.PrintHour();
            time1.PrintMinute();
            time1.PrintSecond();
            time1.PrintTimeEuropeanFormat();
            time1.PrintTimeAmericanFormat();

            Times time2 = new Times(14, 17, 20);
            time2.PrintHour();
            time2.PrintMinute();
            time2.PrintSecond();
            time2.PrintTimeEuropeanFormat();
            time2.PrintTimeAmericanFormat();

            Times time3 = new Times(25, -10, 65);
            time3.PrintHour();
            time3.PrintMinute();
            time3.PrintSecond();
            time3.PrintTimeEuropeanFormat();
            time3.PrintTimeAmericanFormat();
        }
    }
}
