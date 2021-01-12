using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string[] femaleNames = {"Мария", "Анна", "Валентина", "Лидия", "Александра", "Евгения", "Ирина",
            "Софья", "Людмила", "Ксения", "Виктория", "Марина", "Инна", "Светлана", "Яна", "Татьяна", "Ева"};

            string[] femalePatronymic = { "Ивановна", "Петровна", "Егоровна", "Александровна", "Алексеевна",
            "Евгеньевна", "Геннадьевна", "Семеновна", "Львовна", "Николаевна", "Сергеевна", "Платоновна",
            "Михайловна", "Юрьевна", "Федоровна", "Робертовна", "Владимировна"};

            string[] femaleSurname = { "Михайлова", "Спирина", "Кужелева", "Борисенок", "Глаговская", "Грибацкая",
            "Ходорова", "Лысенко", "Головина", "Щербакова", "Пачикина", "Мизонова", "Яцкевич", "Зорина", "Петухова"};

            string[] emails = { "ak@dreamteam-company.ru", "ayaroslavtseva@pyrus.com", "ekruglova@russoutdoor.ru",
            "my_sales@mail.ru", "rostexrf@yandex.ru", "support@windows-pro.store", "hife@yandex.ru", "thotamon@gmail.com", "akadpavlova@yandex.ru",
            "fuks.ekaterina@sogaz.ru", "slivina11@mail.ru", "yuliya.yunina@allianz.ru", "lfetkulova@cislink.com", "eksokolova@azbukavkusa.ru" };

            string[,] phoneBook = new string[5, 2];

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                phoneBook[i, 0] = femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, femaleSurname.Length)];
                phoneBook[i, 1] = emails[rnd.Next(0, emails.Length)];
                Console.WriteLine($"{phoneBook[i, 0]} - {phoneBook[i, 1]}");
            }
            Console.ReadKey();
        }
    }
}
