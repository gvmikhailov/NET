using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summ
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int endOfRow = rnd.Next(1, 10000);
            GetSummOfRow(endOfRow);
        }
        static void GetSummOfRow (int endOfRow)
        {
            long summOfRow = 0;
            for (int i = 0; i < endOfRow; i++)
            {
                summOfRow += i;
            }
            Console.WriteLine("Сумма ряда чисел от 1 до {0} равна {1}", endOfRow, summOfRow);
        }
    }
}
