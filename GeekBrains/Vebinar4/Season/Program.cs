using System;

namespace Season
{
    class Program
    {
        enum Seasons : byte
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }

        enum Monthes : byte
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца и нажмите Enter:");
            string month = Console.ReadLine();
            byte monthNumber;
            string rusSeason = String.Empty;
            if (Byte.TryParse(month, out monthNumber) == true)
            {
                if (monthNumber > 0 && monthNumber < 13)
                {
                    Seasons season = GetSeason(monthNumber);
                    switch (season)
                    {
                        case Seasons.Autumn :
                            rusSeason = "Осень";
                            break;
                        case Seasons.Winter:
                            rusSeason = "Зима";
                            break;
                        case Seasons.Spring:
                            rusSeason = "Весна";
                            break;
                        case Seasons.Summer:
                            rusSeason = "Лето";
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Номер месяца должен быть от 1 до 12!");
                }                    
            }

            Console.WriteLine($"Сейчас {rusSeason}");
            Console.ReadKey();
        }

        static Seasons GetSeason(byte month)
        {
            Seasons season = Seasons.Winter;
            switch (month)
            {
                case byte i when i == (byte)Monthes.December || i == (byte)Monthes.January || i == (byte)Monthes.February :
                    season = Seasons.Winter;
                    break;
                case byte i when i == (byte)Monthes.March || i == (byte)Monthes.April || i == (byte)Monthes.May:
                    season = Seasons.Spring;
                    break;
                case byte i when i == (byte)Monthes.June || i == (byte)Monthes.July || i == (byte)Monthes.August:
                    season = Seasons.Summer;
                    break;
                case byte i when i == (byte)Monthes.September || i == (byte)Monthes.October || i == (byte)Monthes.November:
                    season = Seasons.Winter;
                    break;
            }
            return season;
        }
    }
}
