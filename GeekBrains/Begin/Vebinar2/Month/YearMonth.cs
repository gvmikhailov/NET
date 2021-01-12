using System;

namespace Month
{
    public class YearMonth
    {
        enum YearMonthes
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        public static void Main(string [] args)
        {
            int monthNumber;
            if (Int32.TryParse(args[0], out monthNumber) == true)
            {
                if (monthNumber > 0 && monthNumber < 13)
                    Console.WriteLine($"Название месяца: {(YearMonthes)monthNumber}");                    
                else
                    Console.WriteLine("Номер месяца должен быть от 1 до 12!");
            }
            else
            {
                Console.WriteLine("Введенный номер месяца не является числом!");
            }
        }
    }
}
