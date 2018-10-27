using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int
{
    class Int
    {
        public int Number { get; set; }

        public Int (int number)
        {
            Number = number;
        }

        internal void SetNumberNull()
        {
            Number = 0;
        }

        internal void SetNumber(int setnumber)
        {
            Number = setnumber;
        }

        internal void PrintNumber()
        {
            Console.WriteLine($"Число - {Number}");
        }

        internal static Int SummNumber (Int number1, Int number2)
        {            
            int summ = number1.Number + number2.Number;
            return new Int(summ);
        }

    }
}
