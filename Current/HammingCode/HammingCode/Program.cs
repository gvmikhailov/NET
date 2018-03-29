using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 1;
            byte y = 1;
            byte z = 1;
            Console.WriteLine((x + y + z) % 2);
        }
    }
}
