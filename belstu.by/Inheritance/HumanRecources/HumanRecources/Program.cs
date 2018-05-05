using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRecources
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

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

            string[] workshops = { "Сборочно-комплектовочном", "Электромеханическом", "Колесно-тележечном", "Окраски" };
            string[] specialtys = { "Сварщик", "Слесарь", "Столяр", "Токарь", "Плиточник", "Крановщик", "Маляр", "Фрезеровщик", "Электрик" };

            string[] qualifications = { "Инженер III категории", "Инженер II категории", "Инженер III категории" };
            string[] subdivisions = { "Служба главного инженера", "Управление охраны труда", "Управление качества и стратегического планирования", "Управление инновационной деятельности", "Монтажное" };

            string[] positions = { "Главный инженер", "Генеральный директор", "Директор производства", "Директор дирекции по персоналу", "Технический директор", "Директор УИТ" };

            Employee employeeMale1 = new Employee((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]));
            employeeMale1.PrintInfo();

            Employee employeeFemale1 = new Employee((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, femaleSurname.Length)]));
            employeeFemale1.PrintInfo();

            Employee employeeMale2 = new Worker((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]), specialtys[rnd.Next(0, specialtys.Length)], workshops[rnd.Next(0, workshops.Length)]);
            employeeMale2.PrintInfo();

            Employee employeeFemale2 = new Worker((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, femaleSurname.Length)]), specialtys[rnd.Next(0, specialtys.Length)], workshops[rnd.Next(0, workshops.Length)]);
            employeeFemale2.PrintInfo();

            Employee employeeMale3 = new Engineer((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]), qualifications[rnd.Next(0, qualifications.Length)], subdivisions[rnd.Next(0, subdivisions.Length)]);
            employeeMale3.PrintInfo();

            Employee employeeFemale3 = new Engineer((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, femaleSurname.Length)]), qualifications[rnd.Next(0, qualifications.Length)], subdivisions[rnd.Next(0, subdivisions.Length)]);
            employeeFemale3.PrintInfo();

            Employee employeeMale4 = new Management((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]), positions[rnd.Next(0, positions.Length)]);
            employeeMale4.PrintInfo();

            Employee employeeFemale4 = new Management((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, femaleSurname.Length)]), positions[rnd.Next(0, positions.Length)]);
            employeeFemale4.PrintInfo();
        }
    }
}
