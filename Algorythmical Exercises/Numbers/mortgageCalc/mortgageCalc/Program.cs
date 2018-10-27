using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Калькулятор для ипотеки

namespace mortgageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int interestRate = rnd.Next(7, 21);
            Console.WriteLine("Процентная ставка - {0}% годовых", interestRate);
            int wholeSumm = rnd.Next(10000, 1000001);
            Console.WriteLine("Сумма кредита - {0} {1}", wholeSumm, GetRoubles(wholeSumm));
            int monthRange = rnd.Next(6, 121);
            Console.WriteLine("Количество месяцев - {0}", monthRange);
            CalcMortage(interestRate, wholeSumm, monthRange);
        }

        static void CalcMortage(int interestRate, int wholeSumm, int monthRange)
        {
            double interestRateDouble = interestRate / 12.0 /100;
            double intermediateData = Math.Pow(1 + interestRateDouble, monthRange) - 1;
            double monthPayment = Math.Round(wholeSumm * (interestRateDouble + interestRateDouble / intermediateData), 2);
            int monthPaymentRound = (int)monthPayment;
            double overpayments = (monthPayment * monthRange) - wholeSumm;
            int overpaymentsRound = (int)overpayments;
            Console.WriteLine("Ежемесячный платеж - {0} {1}", monthPayment, GetRoubles(monthPaymentRound));
            Console.WriteLine("Переплата - {0} {1}", overpayments, GetRoubles(overpaymentsRound)); 
        }

        static string GetRoubles(int number)
        {
            string sign = "рублей";
            if (number % 10 == 1)
            {
                sign = "рубль";
            }
            if (number % 10 >= 2 && number % 10 <= 4)
            {
                sign = "рубля";
            }
            if (number % 100 >= 11 & number % 100 <= 20)
            {
                sign = "рублей";
            }
            return sign;
        }
    }
}
