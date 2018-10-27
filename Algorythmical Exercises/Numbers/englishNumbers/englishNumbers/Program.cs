using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Показать как читается число на английском

namespace englishNumbers
{
    enum Numbers
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        eleven,
        twelve,
        thirteen,
        fourteen,
        fifteen,
        sixteen,
        seventeen,
        eighteen,
        nineteen,
        twenty = 20,
        thirty = 30,
        forty = 40,
        fifty = 50,
        sixty = 60,
        seventy = 70,
        eighty = 80,
        ninety = 90
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 1000001);
            string englishNumber = WriteEnglishNumber(number);
            Console.WriteLine("Число {0} в английском языке записывается - {1}", number, englishNumber);
        }

        static string WriteEnglishNumber(int number)
        {
            string englishNumber = string.Empty;
            string engNumberTh = string.Empty;
            string engNumberHun = string.Empty;
            if (number == 1000000)
            {
                return "One million";
            }
            if (number == 0)
            {
                Numbers getZero = 0;
                string zero = getZero.ToString();
                return zero;
            }
            string engNumber = number.ToString();
            int length = engNumber.Length;
            if (length <= 6 && length > 3)
            {
                engNumberTh = engNumber.Substring(0, engNumber.Length - 3);
                engNumberTh = GetStringNumber(engNumberTh, 1) + " thousand";
                engNumberHun = engNumber.Substring(engNumber.Length - 3);
                engNumberHun = GetStringNumber(engNumberHun);
            }
            else
            {
                engNumberHun = GetStringNumber(engNumber, 2);
            }
            engNumber = engNumberTh + " " + engNumberHun;
            return engNumber;
        }

        static string GetStringNumber(string number, int k=0)
        {
            string thousand = string.Empty;
            string hundred = string.Empty;
            string decade = string.Empty;
            string units = string.Empty;
            string result = string.Empty;
            List<int> tripple = number.Select(c => c - '0').ToList();
            if (tripple.Count == 3)
            {
                if (tripple[0] != 0)
                {
                    Numbers getHundred = (Numbers)tripple[0];
                    hundred = getHundred.ToString();
                    result += hundred + " hundred ";
                    tripple.RemoveAt(0);
                }
                else
                {
                    tripple.RemoveAt(0);
                }
            }
            if (tripple.Count == 2)
            {
                if (tripple[0] >= 2)
                {
                    Numbers getDecade = (Numbers)(tripple[0] * 10);
                    decade = getDecade.ToString();
                    result += "and " + decade;
                    tripple.RemoveAt(0);
                }
                else if (tripple[0] > 0 && tripple[0] < 2)
                {
                    Numbers getDecade = (Numbers)(tripple[0] * 10 + tripple[1]);
                    decade = getDecade.ToString();
                    result += "and " + decade;
                    tripple.RemoveAt(0);
                    tripple.RemoveAt(0);
                }
                else
                {
                    tripple.RemoveAt(0);
                }
                if (tripple.Count == 1)
                {
                    if (tripple[0] == 0)
                    {
                        tripple.RemoveAt(0);
                    }
                    else
                    {
                        Numbers getUnits = (Numbers)tripple[0];
                        units = getUnits.ToString();
                        if (decade == string.Empty)
                        { 
                            result += "and " + units;
                        }
                        else
                        {
                            result += " " + units;
                        }
                        tripple.RemoveAt(0);
                    }
                }                
            }
            if (tripple.Count == 1)
            {
                if (tripple[0] != 0 && k==1)
                {
                    Numbers getThousand = (Numbers)tripple[0];
                    thousand = getThousand.ToString();
                    result += thousand;
                    tripple.RemoveAt(0);
                }
                else if (tripple[0] != 0 && k == 2)
                {
                    Numbers getUnits = (Numbers)tripple[0];
                    units = getUnits.ToString();
                    result += units;
                    tripple.RemoveAt(0);
                }
                else
                {
                    tripple.RemoveAt(0);
                }
            }
            return result;
        }
    }
}

