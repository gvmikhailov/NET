using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1876

namespace Centipede
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rightSneakers = rnd.Next(40, 101);
            Console.WriteLine("Количество правых тапок - {0}", rightSneakers);
            int leftSneakers = rnd.Next(40, 101);
            Console.WriteLine("Количество левых тапок - {0}", leftSneakers);
            int shoeingTime = rightSneakers * 2 + leftSneakers;
            Console.WriteLine("Сороконожке в самом худшем случае потребуется {0} минут", shoeingTime);
        }
    }
}
