using System;

namespace Vebinar8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.Name) || Properties.Settings.Default.Age == 0 || String.IsNullOrEmpty(Properties.Settings.Default.Occupation))
            { 
                if (String.IsNullOrEmpty(Properties.Settings.Default.Name))
                {
                    Console.WriteLine("Введите свое имя:");
                    Properties.Settings.Default.Name = Console.ReadLine();
                }
                if (Properties.Settings.Default.Age == 0)
                {
                    Console.WriteLine("Введите свой возраст:");
                    string ageString = Console.ReadLine();
                    int age;
                    Properties.Settings.Default.Age = Int32.TryParse(ageString, out age) == true ? age : 0;
                }
                if (String.IsNullOrEmpty(Properties.Settings.Default.Occupation))
                { 
                    Console.WriteLine("Введите свой род деятельности:");
                    Properties.Settings.Default.Occupation = Console.ReadLine();
                }
                Properties.Settings.Default.Save();
            }
            else
            { 
                Console.WriteLine(Properties.Settings.Default.Hello);
                Console.WriteLine($"Ваше имя: {Properties.Settings.Default.Name}\r\nВаш возраст: {Properties.Settings.Default.Age}\r\nВаш род деятельности: {Properties.Settings.Default.Occupation}");
            }
        }
    }
}
