using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal enum Monthes
    {
        января = 1,
        февраля,
        марта,
        апреля,
        мая,
        июня,
        июля,
        августа,
        сентября,
        октября,
        ноября,
        декабря
    }

    class Program
    {
        static void Main(string[] args)
        {            
            Dates today = new Dates(05, 04, 2018);
            today.PrintShortDate();
            today.PrintLongDate();
            Dates date1 = new Dates(30, 03, 1978);
            date1.PrintShortDate();
            date1.PrintLongDate();
            Dates date2 = new Dates(03, 10, 1977);
            date2.PrintShortDate();
            date2.PrintLongDate();
            Console.WriteLine(date2.GetDay());
            Console.WriteLine(date2.GetMonth());
            Console.WriteLine(date2.GetYear());
        }
    }
}
