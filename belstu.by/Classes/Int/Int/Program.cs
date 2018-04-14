using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Int number1 = new Int(10);
            Int number2 = new Int(15);
            number2.SetNumber(13);
            number1.SetNumberNull();
            Int number3 = Int.SummNumber(number1, number2);
            number1.PrintNumber();
            number2.PrintNumber();
            number3.PrintNumber();
        }
    }
}
