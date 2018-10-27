using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute
{
    class Human
    {
        private DateTime _birhDate;

        public string Name { get; set; }
        public DateTime BirthDate
        {
            get
            {
                return _birhDate;
            }
            set
            {
                _birhDate =value;
            }
        }

        public Human (string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        internal virtual void PrintInfo()
        {
            Console.WriteLine("ФИО - {0},\nДата Рождения - {1}", Name, BirthDate.ToShortDateString());
            Console.WriteLine();
        }

        internal static DateTime SetBirhDate(int year, int month, int day)
        {
            int dateYear = year;
            int dateMonth = month;
            int dateDay = day;

            int[] daysValues = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (DateTime.IsLeapYear(year) == true && dateMonth == 2)
            {
                daysValues[1] = 29;
            }

            if (dateYear < 1900)
            {
                Console.WriteLine("Значение года рождения не может быть меньше 1900, установлено значение 1900");
                Console.WriteLine();
                year = 1900;
            }
            else if (dateYear > DateTime.Today.Year)
            {
                Console.WriteLine("Значение года рождения не может быть больше {0}, установлено значение {0}", DateTime.Today.Year);
                Console.WriteLine();
                year = DateTime.Today.Year;
            }
            else
            {
                year = dateYear;
            }

            if (dateMonth < 1)
            {
                Console.WriteLine("Значение месяца рождения не может быть меньше января, установлено значение январь");
                Console.WriteLine();
                month = 1;
            }
            else if (dateMonth > 12)
            {
                Console.WriteLine("Значение месяца рождения не может быть больше декабря, установлено значение декабрь");
                Console.WriteLine();
                month = 12;
            }
            else
            {
                month = dateMonth;
            }

            int dayValue = daysValues[month - 1];

            if (dateDay < 1)
            {
                Console.WriteLine("Значение дня рождения не может быть меньше 01, установлено значение 01");
                Console.WriteLine();
                day = 1;
            }
            else if (dateDay > dayValue)
            {
                Console.WriteLine("Значение дня рождения не может быть больше {0} дней в этом месяце, установлено значение {0}", dayValue);
                Console.WriteLine();
                day = dayValue;
            }
            else
            {
                day = dateDay;
            }

            return new DateTime(year, month, day);
        }
    }
}
