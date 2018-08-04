using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Программа проверяет на то, что введенная строка является палиндромом

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "А роза упала на лапу Азора.";
            string pattern = @"(\s+)|(\W)";
            Regex reg = new Regex(pattern);
            palindrome = reg.Replace(palindrome, string.Empty);
            // string checkPalindrome = palindrome.ToLower();
            Console.WriteLine(palindrome);
            CheckPalindrome(palindrome);
        }
    

    static void CheckPalindrome(string checkPalindrome)
		{
            CultureInfo myCulture = new CultureInfo("ru-RU");
			List<char> palindromeList = checkPalindrome.ToList();
            bool isPalindrome = false;
			for (int i = 0, j = palindromeList.Count - 1; i<palindromeList.Count / 2; i++, j--)
			{
                
                if (char.ToLower(palindromeList[i], myCulture) == char.ToLower(palindromeList[j], myCulture))
				{
					isPalindrome = true;
					continue;
				}
				else
				    {
					isPalindrome = false;
					break;
				}
			}
			if(isPalindrome == false)
			{
				Console.WriteLine("Выражение не является палиндромом");
			}
			else
			{
				Console.WriteLine("Выражение является палиндромом");
			}
		}
    }
}
