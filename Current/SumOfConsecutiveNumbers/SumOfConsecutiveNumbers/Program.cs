using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1120

namespace SumOfConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int summOfRow = rnd.Next(0, 1000);
            int memberOfRowR;
            int memberOfRowA;
            int result;
            Console.WriteLine("Сумма ряда - " + summOfRow);
            IntegerMembersOfRow(summOfRow, out memberOfRowA, out memberOfRowR);
            Console.WriteLine("Значения A - {0}, Значение P - {1}", memberOfRowA, memberOfRowR);
            CheckerOfSummRow(memberOfRowA, memberOfRowR, summOfRow, out result);
            Console.WriteLine("Проверка: результат суммы ряда при вычесленных А и Р = " + result);
        }
        static void IntegerMembersOfRow (int summOfRow, out int memberOfRowA, out int memberOfRowR)
        {
            int R = 1;
            for (int i = 44720; i >= 1; i--)
            {
                if (summOfRow >= i * (i + 1) / 2 && i % (summOfRow - i * (i + 1) / 2) == 0)
                {
                    R = i;
                    break;
                }
                else
                {
                    continue;
                }
            }
            memberOfRowR = R;
            memberOfRowA = 1 + (summOfRow - memberOfRowR * (memberOfRowR + 1) /2) / memberOfRowR;
        }
        static void CheckerOfSummRow (int memberOfRowA, int memberOfRowR, int summOfRow, out int result)
        {
            result = 0; 
            for (int k = 0; k < memberOfRowR; k++)
            {
                result += (memberOfRowA + k);
            }
        }
    }
}
