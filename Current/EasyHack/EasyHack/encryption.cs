using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHack
{
    partial class Program
    {
        static string Encryption(string word)
        {
            string result = string.Empty;
            List<int> step1 = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                int index = Array.IndexOf(alphabeth, word[i]);
                step1.Add(index);
                Console.Write(index + ", ");
            }
            Console.WriteLine();
            List<int> step2 = new List<int>();
            step2.Add(step1[0] + 5);
            for (int j = 0; j < word.Length - 1; j++)
            {
                int step2Temp = step2[j] + step1[j + 1];
                step2.Add(step2Temp);
            }
            foreach (int m in step2)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            List<int> step3 = new List<int>();
            List<string> step4 = new List<string>();
            int step3temp = 0;
            string step4temp = string.Empty;
            for (int k = 0; k < word.Length; k++)
            {
                if (step2[k] > 25)
                {
                    step3temp = (step2[k] % 26);
                }
                else
                {
                    step3temp = step2[k];
                }
                step3.Add(step3temp);
                step4temp = alphabeth[step3temp].ToString();
                step4.Add(step4temp);
                Console.Write(step3temp + ", ");
            }
            Console.WriteLine();
            result = string.Join("", step4.ToArray());
            return result;
        }
    }
}
