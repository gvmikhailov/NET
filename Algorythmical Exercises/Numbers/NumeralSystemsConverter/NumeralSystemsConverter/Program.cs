using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Перевод из двоичной системы в десятичную и обратно

namespace NumeralSystemsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArray = new int[] { 0, 1 };
            Random rnd = new Random();
            int length = rnd.Next(1, 21);
            string binary = "1";
            for (int i = 0; i < length-1; i++)
            {
                binary += binaryArray[rnd.Next(0, binaryArray.Length)].ToString();
            }
            int binaryLength = binary.Length;
            List<int> powOfTwo = GetPowOf2(binaryLength);
            List<int> listOfbinary = GetListOfBinaryNumber(binary);
            int decimalNumber = GetDecimal(powOfTwo, listOfbinary);
            Console.WriteLine("Число в двоичной системе, которое необходимо преобразовать в число в десятичной системе:");
            Console.WriteLine(binary);
            Console.WriteLine("Число в десятичной системе - {0}", decimalNumber);
            int decimalNumber2Binary = rnd.Next(1, 10001);
            Console.WriteLine("Число в десятичной системе, которое необходимо преобразовать в число в двоичной системе:");
            Console.WriteLine(decimalNumber2Binary);
            Console.WriteLine("Число в двоичной системе - {0}", Decimal2Binary(decimalNumber2Binary));
        }

        static List<int> GetPowOf2(int binaryLength)
        {
            List<int> powOf2 = new List<int>();
            for (int i = 0; i < binaryLength; i++)
            {
                powOf2.Add((int)Math.Pow(2, i));
            }
            powOf2.Reverse();
            return powOf2;
        }

        static List<int> GetListOfBinaryNumber(string binary)
        {
            List<int> string2list = new List<int>();
            string2list = binary.Select(c => c - '0').ToList();
            return string2list;
        }

        static int GetDecimal(List<int> powOfTwo, List<int> listOfbinary)
        {
            int decimalNumber = 0;
            for (int i = 0; i < powOfTwo.Count; i++)
            {
                if(listOfbinary[i] == 1)
                {
                    decimalNumber += powOfTwo[i];
                }
                else
                {
                    continue;
                }
            }
            return decimalNumber;
        }

        static string Decimal2Binary(int decimalNumber)
        {
            List<int> binaryNumber = new List<int>();
            while (decimalNumber != 1)
            {
                
                if (decimalNumber % 2 == 0)
                {                    
                    binaryNumber.Add(0);
                    decimalNumber /= 2;
                }
                else
                {
                    binaryNumber.Add(1);
                    decimalNumber /= 2;
                }
                if (decimalNumber == 1)
                {
                    binaryNumber.Add(1);
                }
            }
            binaryNumber.Reverse();
            string binary = String.Join("", binaryNumber);
            return binary;
        }
    }
}
