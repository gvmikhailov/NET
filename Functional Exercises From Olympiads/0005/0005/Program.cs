using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOrFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            int howManyLessons = rnd.Next(1, 101);
            int[] daysOfMonth = new int[howManyLessons];
            for (int i = 0; i < daysOfMonth.Length; i++)
            {
                daysOfMonth[i] = rnd.Next(1, 32);
            }
            daysOfMonth = daysOfMonth.Distinct().ToArray();
            Array.Sort(daysOfMonth);
            Console.WriteLine("Вот по каким числам проходили уроки:");
            foreach (int m in daysOfMonth)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Может ли Вася расчитывать на 4? - {0}", TakeConfidenceOfFourMark(daysOfMonth));
        }
        static string TakeConfidenceOfFourMark(int [] daysOfMonth)
        {
            int tree = 0;
            int four = 0;            
            for (int k = 0; k < daysOfMonth.Length; k++)
            {
                
                if (daysOfMonth[k] % 2 == 0)
                {
                    four += 1;
                }
                else
                {
                    tree += 1;
                }
            }
            string answer = (four >= tree)?"Да":"Нет";
            return answer;
        }
    }
}
