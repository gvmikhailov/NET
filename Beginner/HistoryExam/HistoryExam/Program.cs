using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1196

namespace HistoryExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tutorDatesCounter = rnd.Next(100, 501);
            Console.WriteLine("Количество дат в списке преподавателя - {0}", tutorDatesCounter);
            int studentDatesCounter = rnd.Next(100, 501);
            Console.WriteLine("Количество дат в списке студента - {0}", studentDatesCounter);
            List<int> tutorDates = new List<int>();
            List<int> studentDates = new List<int>();
            Console.WriteLine("Даты преподавателя:");
            for (int i = 0; i < tutorDatesCounter; i++)
            {
                tutorDates.Add(rnd.Next(0, 2018));
                Console.Write(tutorDates[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Даты студента:");
            for (int j = 0; j < studentDatesCounter; j++)
            {
                studentDates.Add(rnd.Next(0, 2018));
                Console.Write(studentDates[j] + ", ");
            }
            Console.WriteLine();
            GetCoincidenceDates(tutorDates, studentDates);
        }
        static void GetCoincidenceDates (List<int> tutorDates, List<int> studentDates)
        {
            int coincidenceDates = 0;
            for (int k = 0; k < studentDates.Count; k++)
            {
                for (int l = 0; l < tutorDates.Count; l++)
                {
                    if (studentDates[k] == tutorDates[l])
                    {
                        coincidenceDates += 1;
                    }
                }
            }
            Console.WriteLine("Найдено {0} совпадений", coincidenceDates);
        }
    }
}
