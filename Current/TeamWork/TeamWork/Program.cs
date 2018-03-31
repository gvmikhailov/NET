using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1581

namespace TeamWork
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 2, 2, 2, 1, 4, 5, 5, 5, 5, 5, 5, 6, 7, 1, 1, 4, 4, 3, 3, 3, 9 };
            int counter = 1;
            List<int> endNumbers = new List<int>();
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    counter += 1;
                    continue;
                }
                else
                {
                    endNumbers.Add(counter);
                    endNumbers.Add(numbers[i - 1]);
                    counter = 1;
                }
            }
            counter = 1;
            for (int k = numbers.Length - 1; k > 0; k--)
            {
                if (numbers[k] == numbers[k - 1])
                {
                    counter += 1;
                    continue;
                }
                else
                {
                    endNumbers.Add(counter);
                    endNumbers.Add(numbers[k]);
                    break;
                }

            }
            foreach (int m in endNumbers)
            {
                Console.Write(m + ", ");
            }
        }
    }
}
