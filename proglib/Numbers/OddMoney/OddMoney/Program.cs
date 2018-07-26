using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пользователь вводит стоимость и количество денег. 
// Программа рассчитывает сдачу и количество купюр и монет, необходимых для сдачи.

namespace OddMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int billPrice = rnd.Next(1, 10001);
            int money = rnd.Next(billPrice, 10001);
            int moneyChange = rnd.Next(1, 100);
            GetOddMoney(money, billPrice, moneyChange);
        }

        static void GetOddMoney(int money, int billPrice, int moneyChange)
        {
            int oddMoney = money - (billPrice + 1);
            int[] moneyInt = new int[] { 5000, 2000, 1000, 500, 200, 100, 50, 10, 5, 2, 1 };
            int[] coins = new int[] { 50, 10, 5, 1 };
            Dictionary<int, int> numbersOfNotes = new Dictionary<int, int>(11);
            Dictionary<int, int> numbersOfCoins = new Dictionary<int, int>(4);

            int numbers = 0;
            for (int i = 0; i < moneyInt.Length; i++)
            {                
                if (oddMoney >= moneyInt[i])
				{
                numbers = oddMoney / moneyInt[i];
                oddMoney = (oddMoney % moneyInt[i]);
                numbersOfNotes.Add(moneyInt[i], numbers);
                    if (oddMoney == 0)
                    {
                        break;
                    }
                    else if (oddMoney == 1)
                    {
                        numbersOfNotes.Add(1, 1);
                        break;
                    }
                    else
                    { 
                    continue;
                    }
                }
				else
				{
                continue;
                }
            }

            int numbersOfCoin = 0;
            int oddMoneyChange = 100 - moneyChange;
            for (int j=0; j<coins.Length; j++)
			{
                if (oddMoneyChange >= coins[j])
                {
                    numbersOfCoin = oddMoneyChange / coins[j];
                    oddMoneyChange = (oddMoneyChange % coins[j]);
                    numbersOfCoins.Add(coins[j], numbersOfCoin);
                    if (oddMoneyChange == 0)
                    {
                        break;
                    }
                    else if (oddMoneyChange == 1)
                    {
                        numbersOfCoins.Add(1, 1);
                        break;
                    }
                    else
                    { 
                        continue;
                    }
                }
                else
                {
                    continue;
                }
			}
            double summOfBill = (double)billPrice + ((double)moneyChange / 100);
            double oddMoneyAll = (double)money - summOfBill;
            Console.WriteLine("Сумма покупки - {0}", summOfBill);
            Console.WriteLine("Внесено денег - {0}", money);
            Console.WriteLine("Сдача - {0}", oddMoneyAll);
            Console.WriteLine("Купюры и монеты для сдачи: ");
            foreach (var m in numbersOfNotes)
            {
                Console.WriteLine("{0} по {1} {2}", m.Value, m.Key, GetRoubles(m.Key));
            }
            foreach (var n in numbersOfCoins)
            {
                Console.WriteLine("{0} по {1} {2}", n.Value, n.Key, GetKopeck(n.Key));
            }
        }

        static string GetRoubles (int value)
        {
            string roubles = string.Empty;
            if (value == 2)
            {
                roubles = "рубля";
            }
            else if (value == 1)
            {
                roubles = "рублю";
            }
            else
            {
                roubles = "рублей";
            }
            return roubles;
        }

        static string GetKopeck(int value)
        {
            string kopeck = string.Empty;
            if (value == 1)
            {
                kopeck = "копейке";
            }
            else
            {
                kopeck = "копеек";
            }
            return kopeck;
        }

    }
}
