using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject4Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 2, 1, 4, 0 };
            Solution solution1 = new Solution();
            int a = solution1.solution(array);
            Console.WriteLine(a);
        }
    }
    class Solution
    {
        public int solution(int[] A)
        {
            long result = 0;
            Dictionary<long, int> dps = new Dictionary<long, int>();
            Dictionary<long, int> dpe = new Dictionary<long, int>();

            for (int i = 0; i < A.Length; i++)
            {
                Inc(dps, Math.Max(0, i - A[i]));
                Inc(dpe, Math.Min(A.Length - 1, i + A[i]));
            }

            long t = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int value;
                if (dps.TryGetValue(i, out value))
                {
                    result += t * value;
                    result += value * (value - 1) / 2;
                    t += value;
                    if (result > 10000000)
                        return -1;
                }
                dpe.TryGetValue(i, out value);
                t -= value;
            }

            return (int)result;
        }
        private static void Inc(Dictionary<long, int> values, long index)
        {
            int value;
            values.TryGetValue(index, out value);
            values[index] = ++value;
        }
    }
}
    
