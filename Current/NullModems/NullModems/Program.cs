using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1131

namespace NullModems
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int personalComputers = rnd.Next(1, 151);
            Console.WriteLine("Персональных компьютеров - {0}", personalComputers);
            int nullModemCables = rnd.Next(1, 21);
            Console.WriteLine("Нульмодемных кабелей - {0}", nullModemCables);
            Console.WriteLine("Минимальное время (в часах), требующееся для копирования программы на все компьютеры - {0}", GetHoursToCopy(personalComputers, nullModemCables));
        }
        static int GetHoursToCopy(int personalComputers, int nullModemCables)
        {
            int hours = 0;
            int donePersonalComputers = 2;
            for (int i = 2; i < personalComputers; i++)
            {
                if (donePersonalComputers <= nullModemCables)
                {
                    hours += 1;
                    donePersonalComputers = 2 * (i - 1);
                }
                else
                {
                    if (donePersonalComputers < personalComputers)
                    {
                        donePersonalComputers += nullModemCables;
                        hours += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return hours;
        }
    }
}
