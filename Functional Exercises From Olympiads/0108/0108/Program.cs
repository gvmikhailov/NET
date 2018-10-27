using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDeafPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int transferNumber = rnd.Next(0, 100000);
            Console.WriteLine("Было передано число - {0}", transferNumber);
        }
    }
}
