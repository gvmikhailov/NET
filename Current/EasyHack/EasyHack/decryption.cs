using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHack
{
    partial class Program
    {
        static string Decryption(string decodeWord, out string word)
        {
            List<int> step1 = new List<int>();
            for (int i = 0; i < decodeWord.Length; i++)
            {
                int index = Array.IndexOf(alphabeth, decodeWord[i]);
                step1.Add(index);
                Console.Write(index + ", ");
            }
            Console.WriteLine();
            List<int> step2 = new List<int>();
            if (step1[0] >= 5)
            {
                step2.Add(step1[0]);
            }
            else
            {
                step2.Add(step1[0] + 26);
            }
            Console.Write(step2[0] + ", ");
            for (int j = 1; j < decodeWord.Length; j++)
            {
                step2.Add(step1[j]);
                int step2temp = step2[j];
                while (step2[j - 1] > step2temp)
                {
                    step2temp += 26;
                }
                step2.Remove(step2[j]);
                step2.Add(step2temp);
                Console.Write(step2[j] + ", ");
            }
            Console.WriteLine();
            List<int> step3 = new List<int>();
            for (int k = decodeWord.Length - 1; k > 0; k--)
            {
                int step3temp = step2[k] - step2[k - 1];
                step3.Add(step3temp);
            }
            step3.Add(step2[0] - 5);
            step3.Reverse();
            string step4temp = string.Empty;
            List<string> step4 = new List<string>();
            foreach (int m in step3)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            for (int l = 0; l < decodeWord.Length; l++)
            {
                step4temp = alphabeth[step3[l]].ToString();
                step4.Add(step4temp);
            }
            word = string.Join("", step4.ToArray());
            return word;
        }
    }
}
