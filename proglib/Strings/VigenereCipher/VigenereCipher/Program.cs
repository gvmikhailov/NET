using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Шифр Виженера - Шифратор и Дешифратор

namespace VigenereCipher
{
    class Program
    {
        static List<char> alphabeth = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string word = "THISISMYPHRAZE";
            string key = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                key += alphabeth[rnd.Next(0, alphabeth.Count)];
            }
            Console.WriteLine("Зашифруем шифром Виженера слово - {0}", word);
            Console.WriteLine("Ключ для шифрования - {0}", key);
            string encryptWord = VigenereEncryption(word, key);
            Console.WriteLine("Зашифрованное послание - {0}", encryptWord);
            string decryptWord = VigenereDecryption(encryptWord, key);
            Console.WriteLine("Обратно расшифрованное послание - {0}", decryptWord);
        }

        static string VigenereEncryption(string word, string key)
        {
            string encryptWord = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                int position = alphabeth.IndexOf(word[i]) + alphabeth.IndexOf(key[i]);
                {
                    if(position > 26)
                    {
                        position = position - 26;
                        encryptWord += alphabeth[position];
                    }
                    else
                    {
                        encryptWord += alphabeth[position];
                    }
                }
            }             
            return encryptWord;
        }

        static string VigenereDecryption(string encryptWord, string key)
        {
            string decryptWord = string.Empty;
            for (int i = 0; i < encryptWord.Length; i++)
            {
                int position = alphabeth.IndexOf(encryptWord[i]) - alphabeth.IndexOf(key[i]);
                {
                    if (position < 0)
                    {
                        position = 26 - Math.Abs(position);
                        decryptWord += alphabeth[position];
                    }
                    else
                    {
                        decryptWord += alphabeth[position];
                    }
                }
            }
            return decryptWord;
        }
    }
}
