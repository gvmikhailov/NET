using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// «синий язык», иногда его называют «Солёный язык» или «Солнечный язык»

namespace RussianPigLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу, которую необходимо перевести на \"Соленый язык\": ");
            string phraze = Console.ReadLine();
            Regex regex = new Regex(@"([а-я, \s, \W])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(phraze);
            if(matches.Count == phraze.Length)
            { 
                TranslateToPigLanguage(phraze);
            }
            else
            {
                Console.WriteLine("В вашей фразе присутствовали не киррилические символы..");
            }
            Console.ReadKey();
        }

        static void TranslateToPigLanguage(string phraze)
        {
            List<char> vowels = new List<char> { 'а', 'у', 'е', 'о', 'э', 'я', 'и', 'ы', 'ю', 'ё',
                'А', 'У', 'Е', 'О', 'Э', 'Я', 'И', 'Ю', 'Ё' };
            StringBuilder sb = new StringBuilder(phraze);
            foreach(char t in vowels)
            {
                sb.Replace(t.ToString(), t.ToString() + "c" + t.ToString().ToLower());
            }
            Console.WriteLine(sb);
        }
    }
}
