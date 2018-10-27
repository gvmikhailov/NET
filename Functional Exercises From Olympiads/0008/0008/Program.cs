using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariphmethika
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int firstFactor = rnd.Next(1, 101);
            int secondFactor = rnd.Next(1, 101);
            int composition = rnd.Next(1, 1000000);
            Console.WriteLine("Равно ли произведение {0} на {1} числу {2}? - {3}", firstFactor, secondFactor, composition, GetAnswerOfCompositionTwoNumbers(firstFactor, secondFactor, composition));
        }
        static string GetAnswerOfCompositionTwoNumbers (int firstFactor, int secondFactor, int composition)
        {
            string answer = composition == firstFactor * secondFactor ? "Да" : "Нет";
            return answer;
        }
    }
}
