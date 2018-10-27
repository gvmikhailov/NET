using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Times
    {
        private int _hour;
        private int _minute;
        private int _second;

        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение для часа на может быть отрицательным! Установлено значение 0");
                    _hour = 0;
                }
                else if (value > 23)
                {
                    Console.WriteLine("Значение для часа на может быть больше 23! Установлено значение 23");
                    _hour = 23;
                }
                else
                {
                    _hour = value;
                }
            }
        }

        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение для минуты на может быть отрицательным! Установлено значение 0");
                    _minute = 0;
                }
                else if (value > 59)
                {
                    Console.WriteLine("Значение для минуты на может быть больше 59! Установлено значение 59");
                    _minute = 59;
                }
                else
                {
                    _minute = value;
                }
            }
        }

        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение для секунды на может быть отрицательным! Установлено значение 0");
                    _second = 0;
                }
                else if (value > 59)
                {
                    Console.WriteLine("Значение для секунды на может быть больше 59! Установлено значение 59");
                    _second = 59;
                }
                else
                {
                    _second = value;
                }
            }
        }

        internal Times (int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        internal void PrintHour()
        {
            Hours takeHourString = (Hours)GetNumberOfEnum(Hour);
            string hourString = GetNullToNineString(Hour);
            Console.WriteLine("Сейчас {0} {1}", hourString, takeHourString);            
        }

        internal void PrintMinute()
        {
            Minutes takeMinutesString = (Minutes)GetNumberOfEnum(Minute);
            string minuteString = GetNullToNineString(Minute);
            Console.WriteLine("Сейчас {0} {1}", minuteString, takeMinutesString);
        }

        internal void PrintSecond()
        {
            Seconds takeSecondString = (Seconds)GetNumberOfEnum(Second);
            string secondString = GetNullToNineString(Second);
            Console.WriteLine("Сейчас {0} {1}", secondString, takeSecondString);            
        }

        internal void PrintTimeEuropeanFormat()
        {
            Hours takeHourString = (Hours)GetNumberOfEnum(Hour);
            Minutes takeMinutesString = (Minutes)GetNumberOfEnum(Minute);
            Seconds takeSecondString = (Seconds)GetNumberOfEnum(Second);
            string hourString = GetNullToNineString(Hour);
            string minuteString = GetNullToNineString(Minute);
            string secondString = GetNullToNineString(Second);
            Console.WriteLine($"Европейское время - {hourString} {takeHourString} {minuteString} {takeMinutesString} {secondString} {takeSecondString}");
        }

        internal void PrintTimeAmericanFormat()
        {
            Minutes takeMinutesString = (Minutes)GetNumberOfEnum(Minute);
            Seconds takeSecondString = (Seconds)GetNumberOfEnum(Second);
            string hourString = GetAmericanHourFormat(Hour);
            string minuteString = GetNullToNineString(Minute);
            string secondString = GetNullToNineString(Second);
            Console.WriteLine($"Американское время - {hourString} {minuteString} {takeMinutesString} {secondString} {takeSecondString}");
        }

        internal int GetNumberOfEnum(int value)
        {
            int number = 1;
            if (value % 10 == 1) number = 2;
            if (value % 10 >= 2 && value % 10 <= 4) number = 3;
            if (value % 100 >= 11 & value % 100 <= 20) number = 1;
            return number;
        }

        internal string GetNullToNineString(int value)
        {
            string printNullToNine = string.Empty;
            if (value < 10)
            {
                printNullToNine = "0" + value.ToString();
            }
            else
            {
                printNullToNine = value.ToString();
            }
            return printNullToNine;
        }

        internal string GetAmericanHourFormat(int value)
        {
            string americanTime = string.Empty;
            if (value <= 12)
            {
                americanTime = GetNullToNineString(value) + " a.m.";
            }
            else
            {
                americanTime = GetNullToNineString(value - 12) + " p.m.";
            }
            return americanTime;
        }
    }
}
