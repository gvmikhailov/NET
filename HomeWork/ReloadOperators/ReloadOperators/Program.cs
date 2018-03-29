using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/39/2014_03_10_peregruzka_operatorov_v_si-sharp.html

namespace ReloadOperators
{
    class Program
    {
        public static double rateUSD = 56.52;
        public static double rateEUR = 69.89;
        public static double rateUSDEUR = 0.81;
        static void Main(string[] args)
        {            
            Money accountOne = new Money(100, "USD");
            Money accountTwo = new Money(162, "EUR");
            Money accountThree = new Money(127200, "RUB");
            Money accountFour = new Money(35, "USD");
            Money accountFive = new Money(127, "EUR");
            Money accountSix = new Money(13568, "RUB");
            GetSummOfTwoAccounts(accountThree, accountTwo);
        }
        public static void GetSummOfTwoAccounts(Money account1, Money account2)
        {
            if (account1 != account2)
            {
                Money accountConvert = Exchange.CurrencyExchange(account1, account2, rateUSDEUR, rateUSD, rateEUR);
                Money summ = account1 + accountConvert;
                Console.WriteLine("Сумма на двух счетах {0} {1}", summ.Amount, summ.Currency);
            }
            else
            {
                Money summ = account1 + account2;
                Console.WriteLine("Сумма на двух счетах {0}", summ.Amount, summ.Currency);
            }
        }
    }
}
