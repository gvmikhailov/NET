using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Шифр Вернама по модулю 26- Шифратор и Дешифратор

namespace VernamCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<char> alphabeth = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string word = "THISISMYPHRAZE";
            string key = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                key += alphabeth[rnd.Next(0, alphabeth.Count)];
            }
            Console.WriteLine("Зашифруем шифром Вернама слово - {0}", word);
            Console.WriteLine("Ключ для шифрования - {0}", key);
            string encryptWord = VernamEncryptionDecription(word, key);
            Console.WriteLine("Зашифрованное послание - {0}", encryptWord);
            string decryptWord = VernamEncryptionDecription(encryptWord, key);
            Console.WriteLine("Обратно расшифрованное послание - {0}", decryptWord);
        }

        static string VernamEncryptionDecription(string word, string key)
        {
            string Word = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                Word += (char)(Convert.ToInt32(word[i]) ^ Convert.ToInt32(key[i]));
            }
            return Word;
        }
    }
}
