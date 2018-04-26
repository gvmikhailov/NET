using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute
{
    class Program
    {
        internal static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            int year = rnd.Next(1850, 2026);
            int month = rnd.Next(-10, 21);
            int day = rnd.Next(-10, 41); 

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

            string[] faculty = { "Авиационная техника", "Радиоэлектроника летательных аппаратов", "Робототехнические и интеллектуальные системы",
            "Информационные технологии и прикладная математика", "Общеинженерной подготовки", "Иностранных языков", "Довузовской подготовки"};

            string[] groupFacultyAT = { "AT-01-0", "AT-02-0", "AT-03-0", "AT-04-0", "AT-05-0", "AT-06-0", "AT-07-0"};
            string[] groupFacultyRLA = { "РЛА-01-0", "РЛА-02-0", "РЛА-03-0", "РЛА-04-0", "РЛА-05-0", "РЛА-06-0", "РЛА-07-0" };
            string[] groupFacultyRIS = { "РИС-01-0", "РИС-02-0", "РИС-03-0", "РИС-04-0", "РИС-05-0", "РИС-06-0", "РИС-07-0" };
            string[] groupFacultyITPM = { "ИТПМ-01-0", "ИТПМ-02-0", "ИТПМ-03-0", "ИТПМ-04-0", "ИТПМ-05-0", "ИТПМ-06-0", "ИТПМ-07-0" };
            string[] groupFacultyOP = { "ОП-01-0", "ОП-02-0", "ОП-03-0", "ОП-04-0", "ОП-05-0", "ОП-06-0", "ОП-07-0" };
            string[] groupFacultyIY = { "ИЯ-01-0", "ИЯ-02-0", "ИЯ-03-0", "ИЯ-04-0", "ИЯ-05-0", "ИЯ-06-0", "ИЯ-07-0" };
            string[] groupFacultyDP = { "ДП-01-0", "ДП-02-0", "ДП-03-0", "ДП-04-0", "ДП-05-0", "ДП-06-0", "ДП-07-0" };

            string[] positions = { "Доцент", "Профессор", "Ассистент", "Заведующий кафедрой", "Старший преподаватель" };

            string[] cathedra = { "Системы автоматического и интеллектуального управления", "Вычислительные машины, системы и сети ",
            "Автоматизированные комплексы систем ориентации и навигации", "Микроэлектронные электросистемы", "Технология приборостроения",
            "Информационные технологии", "Теоретическая электротехника", "Электроэнергетические, электромеханические и биотехнические системы",};

            //string maleFIO = (maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]);
            //string femaleFIO = (femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, maleSurname.Length)]);

            DateTime dt1 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h1 = new Human((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]), dt1);
            h1.PrintInfo();

            DateTime dt2 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h2 = new Human((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, maleSurname.Length)]), dt2);
            h2.PrintInfo();

            DateTime dt3 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h3 = new Enrollee((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, maleSurname.Length)]), dt3, rnd.Next(-20, 150));
            h3.PrintInfo();

            DateTime dt4 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h4 = new Enrollee((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]), dt4, rnd.Next(-20, 150));
            h4.PrintInfo();

            DateTime dt5 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h5 = new Student((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, maleSurname.Length)]), dt5, faculty[0], rnd.Next(-5, 11), groupFacultyAT[rnd.Next(0, groupFacultyAT.Length)]);
            h5.PrintInfo();

            DateTime dt6 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h6 = new Student((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]), dt6, faculty[1], rnd.Next(-5, 11), groupFacultyRLA[rnd.Next(0, groupFacultyRLA.Length)]);
            h6.PrintInfo();

            DateTime dt7 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h7 = new Tutor((femaleNames[rnd.Next(0, femaleNames.Length)] + " " + femalePatronymic[rnd.Next(0, femalePatronymic.Length)] + " " + femaleSurname[rnd.Next(0, maleSurname.Length)]), dt7, positions[rnd.Next(0, positions.Length)], cathedra[rnd.Next(0, cathedra.Length)]);
            h7.PrintInfo();

            DateTime dt8 = Human.SetBirhDate(rnd.Next(1850, 2026), rnd.Next(-10, 21), rnd.Next(-10, 41));
            Human h8 = new Tutor((maleNames[rnd.Next(0, maleNames.Length)] + " " + malePatronymic[rnd.Next(0, malePatronymic.Length)] + " " + maleSurname[rnd.Next(0, maleSurname.Length)]), dt8, positions[rnd.Next(0, positions.Length)], cathedra[rnd.Next(0, cathedra.Length)]);
            h8.PrintInfo();
        }
    }
}
