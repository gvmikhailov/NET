using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/9/2013_04_17_uslovnye_operatory_v_si-sharp_ternarnyj_operator.htm

namespace ConditionalStatements1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int borderLeft = rnd.Next(1, 1001);
            int borderRight = rnd.Next(1001, 2001);
            Console.WriteLine("Заданы границы от {0} до {1}", borderLeft, borderRight);
            Console.WriteLine("В данном диапазоне следующие числа кратны 3 и 7:");
            Console.WriteLine();
            foreach (int m in TakeNumbers(borderLeft,borderRight))
            {
                Console.Write(m + ", ");
            }
        }
        static List <int> TakeNumbers (int borderLeft, int borderRight)
        {
            List<int> aliquotNumbers = new List<int>();
            for (int i = borderLeft; i <= borderRight; i++)
            {
                if (i%3 == 0 && i%7 == 0)
                {
                    aliquotNumbers.Add(i);
                }
                else
                {
                    continue;
                }
            }
            return aliquotNumbers;
        }
    }
}
