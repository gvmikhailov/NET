using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRowMember
{
    class Program
    {
        public static List<long> fibonacciRow = new List<long>();
        static void FillingFibonacciRow (int lenght)
        {
            fibonacciRow.Add(0);
            fibonacciRow.Add(1);
            fibonacciRow.Add(1);
            for (int i = 3; i < lenght; i++)
            {
                fibonacciRow.Add(fibonacciRow[i - 1] + fibonacciRow[i - 2]);
            }
        }
        static void Main(string[] args)
        {
            long memberOfFibonacciRow = 0;
            Console.WriteLine("Введите размер ряда Фибоначчи (от 4 до 50):");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите требуемый номер члена ряда Фибоначчи (от 0 до 50):");
            int member = int.Parse(Console.ReadLine());
            FillingFibonacciRow(lenght);
            memberOfFibonacciRow = GetFibonacciRowMember(member);
            Console.WriteLine("Значение {0} номера члена ряда Фибоначчи = {1}", member, memberOfFibonacciRow);
        }
        static long GetFibonacciRowMember(int member)
        {
            long memberOfFibonacciRow = fibonacciRow.ElementAt(member + 1);
            return memberOfFibonacciRow;
        }
    }
}
