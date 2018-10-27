using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1877

namespace Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int key1 = rnd.Next(0, 10000);
            int key2 = rnd.Next(0, 10000);
            Console.WriteLine("{0} - код первого замка, {1} - код второго замка.", key1, key2);
            Console.WriteLine(GetAnswer(key1, key2));
        }
        static string GetAnswer(int key1, int key2)
        {
            string answer = string.Empty;
            if (key1 % 2 == 0 || key2 % 2 != 0)
                answer = "Вор спионерит велосипед";
            else if (key1 % 2 != 0 || key2 % 2 == 0)
                answer = "Вор не спионерит велосипед";
            return answer;
        }
    }
}
