using System;

namespace Vebinar4
{
    class Program
    {
        enum Gender
        {
            Male,
            Femail
        }

        static void Main(string[] args)
        {
            string[] maleNames = {"Иван", "Петр", "Егор", "Александр", "Алексей", "Евгений", "Геннадий",
            "Семен", "Лев", "Николай", "Сергей", "Платон", "Михаил", "Юрий", "Федор", "Роберт", "Владимир" };
            string[] femaleNames = {"Мария", "Анна", "Валентина", "Лидия", "Александра", "Евгения", "Ирина",
            "Софья", "Людмила", "Ксения", "Виктория", "Марина", "Инна", "Светлана", "Яна", "Татьяна", "Ева"};

            string[] malePatronymic = { "Иванович", "Петрович", "Егорович", "Александрович", "Алексеевич",
            "Евгеньевич", "Геннадьевич", "Семенович", "Львович", "Николаевич", "Сергеевич", "Платонович",
            "Михайлович", "Юрьевич", "Федорович", "Робертович", "Владимирович"};
            string[] femalePatronymic = { "Ивановна", "Петровна", "Егоровна", "Александровна", "Алексеевна",
            "Евгеньевна", "Геннадьевна", "Семеновна", "Львовна", "Николаевна", "Сергеевна", "Платоновна",
            "Михайловна", "Юрьевна", "Федоровна", "Робертовна", "Владимировна"};

            string[] maleSurname = { "Аксенов", "Аронов", "Барсуков", "Багдасаров", "Варов", "Соколов", "Мячин",
            "Мазеев", "Матвиенко", "Нугманов", "Шульга", "Латеев", "Михайлов", "Полещук", "Нестерович", "Махнов" };
            string[] femaleSurname = { "Михайлова", "Спирина", "Кужелева", "Борисенок", "Глаговская", "Грибацкая",
            "Ходорова", "Лысенко", "Головина", "Щербакова", "Пачикина", "Мизонова", "Яцкевич", "Зорина", "Петухова"};

            Random rnd = new Random();

            int FIOCounter = rnd.Next(3, 7);
            string name = String.Empty;
            string patronymic = String.Empty;
            string surname = String.Empty;
            byte gender;

            for (int i = 0; i < FIOCounter; i++)
            {
                Gender gend = (Gender)rnd.Next(0, 2);
                gender = (byte)gend;
                switch (gender)
                {
                    case 0:
                        name = maleNames[rnd.Next(0, maleNames.Length)];
                        patronymic = malePatronymic[rnd.Next(0, malePatronymic.Length)];
                        surname = maleSurname[rnd.Next(0, maleSurname.Length)];
                        break;
                    case 1:
                        name = femaleNames[rnd.Next(0, maleNames.Length)];
                        patronymic = femalePatronymic[rnd.Next(0, malePatronymic.Length)];
                        surname = femaleSurname[rnd.Next(0, maleSurname.Length)];
                        break;
                }
                PrintFIO(surname, patronymic, name);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void PrintFIO(string surname, string patronymic, string name)
        {
            Console.Write($"{name} {patronymic} {surname}");
        }
    }
}
