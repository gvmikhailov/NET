using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=2056

namespace Grants
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberOfExams = rnd.Next(1, 11);            
            double summ = 0;
            double[] intChars = new double[numberOfExams];
            Console.WriteLine("Оценки Васи за {0} экзаменов:", numberOfExams);
            for (int i = 0; i < numberOfExams; i++)
            {
                intChars[i] = rnd.Next(3, 6);                
                summ = summ + intChars[i];
                Console.Write(intChars[i] + "; ");
            }
            double averageMarks = summ / numberOfExams;
            averageMarks = Math.Round(averageMarks, 2);
            Console.WriteLine($"Средняя оценка Васи за {numberOfExams} экзамена - {averageMarks}");
            WriteGrant(averageMarks);
        }
        static void WriteGrant(double averageMarks)
        {
            string grants = string.Empty;
            if (averageMarks == 3)
            {
                grants = "None";
            }
            else if (averageMarks == 5)
            {
                grants = "Named";
            }
            else if (averageMarks >= 4.5 && grants != "None")
            {
                grants = "High";
            }
            else if (averageMarks < 4.5 && grants != "None")
            {
                grants = "Common";
            }
            Console.WriteLine("Стипендия Васи - " + grants);
        }
    }
}
