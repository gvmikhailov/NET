using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Dates
    {
        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("День месяца не может быть < 1, установлено значение 1");
                    _day = 1;
                }
                else if (value > 31)
                {
                    Console.WriteLine("День месяца не может быть > 31, установлено значение 31");
                    _day = 31;
                }
                else
                {
                    _day = value;
                }
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Месяц не может быть < 1, установлено значение 1");
                    _month = 1;
                }
                else if (value > 12)
                {
                    Console.WriteLine("Месяц не может быть > 12, установлено значение 12");
                    _month = 12;
                }
                else
                {
                    _month = value;
                }
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1900)
                {
                    Console.WriteLine("Год не может быть < 1900, установлено значение 1900");
                    _year = 1900;
                }
                else if (value > 2018)
                {
                    Console.WriteLine("Год не может быть > 2018, установлено значение 2018");
                    _year = 2018;
                }
                else
                {
                    _year = value;
                }
            }
        }

        public Dates (int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        internal int GetDay()
        {
            return Day;
        }

        internal int GetMonth()
        {
            return Month;
        }

        internal int GetYear()
        {
            return Year;
        }
        
        internal void PrintShortDate()
        {
            if(Day < 10 && Month < 10)
                Console.WriteLine($"Дата - 0{Day}.0{Month}.{Year}");
            else if(Day < 10)
                Console.WriteLine($"Дата - 0{Day}.{Month}.{Year}");
            else if(Month < 10)
                Console.WriteLine($"Дата - {Day}.0{Month}.{Year}");
            else
                Console.WriteLine($"Дата - {Day}.{Month}.{Year}");
        }

        internal void PrintLongDate()
        {
            Monthes takeMonth = (Monthes)Month;
            if (Day < 10)
                Console.WriteLine($"Дата - 0{Day} {takeMonth} {Year} года");
            else
                Console.WriteLine($"Дата - {Day} {takeMonth} {Year} года");
        }
    }
}
