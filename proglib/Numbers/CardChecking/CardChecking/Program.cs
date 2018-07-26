using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Валидатор кредитной карты. Берет номер кредитной карты от производителя (Visa, MasterCard, American Express, Discover) и проверяет на правильность номер по алгоритму Лунга.

namespace CardChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<long> validCards = new List<long>() {340000000000009, 30000000000004, 6011000000000004, 5500000000000004, 4111111111111111, 3530111333300000, 5019717010103742,
            6799990100000000019, 6220332193223235, 6380479685916382, 2200123456789010, 9792020000000001, 169837398657587, 5060666666666666666};
            long validCard = validCards[rnd.Next(0, validCards.Count)];
            string bcNumber = validCard.ToString();
            List<int> bcNumberList = bcNumber.Select(c => c - '0').ToList();
            bool isValid = CardNumberIsCorrect(bcNumberList);
            Console.WriteLine("Номер карты: {0}", bcNumber);            
            string IN = GetCardIssuingNetwork(bcNumber);
            Console.WriteLine("Платежная система: {0}", IN);
            if(isValid == true)
            {
                Console.WriteLine("Номер карты введен без ошибок");
            }
            else
            {
                Console.WriteLine("Номер карты введен с ошибкой!");
            }
        }

        static string GetCardIssuingNetwork(string bcNumber)
        {
            string IN = string.Empty;
            if(Regex.IsMatch(bcNumber, @"^1\d*"))
            {
                IN = "UATP";
            }
            else if(Regex.IsMatch(bcNumber, @"^[2200–2204]\d*"))
            {
                IN = "MIR";
            }
            else if (Regex.IsMatch(bcNumber, @"^[2221–2720|51–55]\d*"))
            {
                IN = "MasterCard";
            }
            else if (Regex.IsMatch(bcNumber, @"^[34|37]\d*"))
            {
                IN = "American Express";
            }
            else if (Regex.IsMatch(bcNumber, @"^[300-305|3095|36|38-39]\d*"))
            {
                IN = "Dinners Club International";
            }
            else if (Regex.IsMatch(bcNumber, @"^[3528-3589]\d*"))
            {
                IN = "JCB";
            }
            else if (Regex.IsMatch(bcNumber, @"^4\d*"))
            {
                IN = "Visa";
            }
            else if (Regex.IsMatch(bcNumber, @"^[506099–506198|650002–650027]\d*"))
            {
                IN = "Verve";
            }
            else if (Regex.IsMatch(bcNumber, @"^5019\d*"))
            {
                IN = "Dankort";
            }
            else if (Regex.IsMatch(bcNumber, @"^[50|56-58|67]\d*"))
            {
                IN = "Maestro";
            }
            else if (Regex.IsMatch(bcNumber, @"^62\d*"))
            {
                IN = "China Union Pay";
            }
            else if (Regex.IsMatch(bcNumber, @"^[6011|64-65]\d*"))
            {
                IN = "Discover Card";
            }
            else if (Regex.IsMatch(bcNumber, @"^[637-639]\d*"))
            {
                IN = "InstaPayment";
            }
            else if (Regex.IsMatch(bcNumber, @"^[979200–979289]\d*"))
            {
                IN = "Troy";
            }
            else
            {
                IN = "Unknown Issuing Network";
            }
            return IN;
        }

        static bool CardNumberIsCorrect(List<int> bcNumberList)
        {
            bool isCorrect;
            int length = bcNumberList.Count;
            int k;
            int summ = 0;
            List<int> forSumm = new List<int>();
            if (length % 2 == 0)
            {
                k = 0;
            }
            else
            {
                k = 1;
                forSumm.Add(bcNumberList[0]);
            }
            for (int i = k; i < bcNumberList.Count; i += 2)
            {
                int multiply = bcNumberList[i] * 2;
                if (multiply > 9)
                {
                    forSumm.Add(multiply - 9);
                }
                else
                {
                    forSumm.Add(multiply);
                }
                forSumm.Add(bcNumberList[i + 1]);
            }
            foreach (int m in forSumm)
            {
                summ += m;
            }
            if (summ % 10 == 0)
            {
                isCorrect = true;
            }
            else
            {
                isCorrect = false;
            }
            return isCorrect;
        }
    }
}
