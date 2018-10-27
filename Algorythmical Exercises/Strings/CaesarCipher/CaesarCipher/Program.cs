using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Шифр Цезаря - Шифратор и Дешифратор

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int key = rnd.Next(-15, 16);
            string originalPhraze = "MYWORDISAPPLEBUTMYANOTHERWORDISLEMON"; // чтобы не было как в расскаже про пляшущих человечков
            Console.WriteLine("Изначальное выражение: - {0}", originalPhraze);
            Console.WriteLine("Ключ - {0}", key);
            string encryptPhraze = EncryptorDecryptor(originalPhraze, key);
            Console.WriteLine("Напечатаем зашифрованное Шифром Цезаря выражение: - {0}", encryptPhraze);
            string decryptPraze = EncryptorDecryptor(encryptPhraze, -key);
            Console.WriteLine("расшифруем обратно выражение: - {0}", decryptPraze);
        }

        static string EncryptorDecryptor(string originalPhraze, int key)
        {
            string encryptPhraze = string.Empty;
            int j = 0;
            List<char> alphabeth = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < originalPhraze.Length; i++)
            {
                j = alphabeth.IndexOf(originalPhraze[i]) + key;
                if (j < 0)
                {
                    j = alphabeth.Count - (Math.Abs(key)) + alphabeth.IndexOf(originalPhraze[i]);
                    encryptPhraze += alphabeth[j];
                }
				else if (j > (alphabeth.Count - 1))
				{
					j = alphabeth.IndexOf(originalPhraze[i]) - (alphabeth.Count) + (Math.Abs(key));
					encryptPhraze += alphabeth[j];
				}
				else
				{		
					encryptPhraze += alphabeth[j];
				}
			}
			return encryptPhraze;
		}
    }
}
