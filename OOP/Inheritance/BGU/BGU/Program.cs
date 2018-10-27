using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGU
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            
            string address = "Республика Беларусь 220006, г.Минск, ул.Свердлова, 13а";

            List<string> faculties = new List<string>() { "Лесохозяйственный факультет", "Факультет технологии и техники лесной промышленности",
            "Факультет технологии органических веществ", "Факультет химической технологии и техники", "Факультет принттехнологий и медиакоммуникаций",
            "Инженерно-экономический факультет", "Факультет информационных технологий", "Заочный факультет", "Факультет общественных профессий",
            "Факультет доуниверситетской подготовки" };

            List<string> praepostors = new List<string>() {"Иванов И.И", "Петров П.П.", "Сидоров С.С", "Михайлов Г.В." };

            string faculty = faculties[rnd.Next(0, faculties.Count)];
            int course = rnd.Next(1, 6);
            string group = GetFaculty(course,faculty);

            string praepostor = praepostors[rnd.Next(0, praepostors.Count)];

            string subgroup = group + "-00" + rnd.Next(1, 4);
            int numbersOfStudents = rnd.Next(-1, 10);

            bgtu BGTU = new bgtu(address);
            BGTU.PrintInfo();
            Faculties faculty1 = new Faculties(address, faculty);
            faculty1.PrintInfo();
            Groups group1 = new Groups(address, group, praepostor, course);
            group1.PrintInfo();
            Subgroups subgroup1 = new Subgroups(address, group, praepostor, course, numbersOfStudents, subgroup);
            subgroup1.PrintInfo();
        }

        static string GetFaculty(int course, string faculty)
        {
            string group = string.Empty;
            if (faculty == "Лесохозяйственный факультет")
            {
                group = "ЛФ-" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Факультет технологии и техники лесной промышленности")
            {
                group = "ФТиТЛП-" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Факультет технологии органических веществ")
            {
                group = "ФТОВ" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Факультет химической технологии и техники")
            {
                group = "ФХТиТ" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Факультет принттехнологий и медиакоммуникаций")
            {
                group = "ФПиМ" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Инженерно-экономический факультет")
            {
                group = "ИЭФ" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Факультет информационных технологий")
            {
                group = "ФИТ" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Заочный факультет")
            {
                group = "ЗФ" + course + "-0" + rnd.Next(1, 11);
            }
            else if (faculty == "Факультет общественных профессий")
            {
                group = "ФОП" + course + "-0" + rnd.Next(1, 11);
            }
            else
            {
                group = "ФДП" + course + "-0" + rnd.Next(1, 11);
            }
            return group;
        }
    }
}
