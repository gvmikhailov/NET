using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = rnd.Next(2, 100);
            int[] middlePoints = new int[length];
            for (int i = 0; i < length; i++)
            {
                middlePoints[i] = rnd.Next(0, 100);
            }
            int intersections = solution(middlePoints);
            Console.WriteLine("Кругов - {0}\nИз них пересекаются - {1}", middlePoints.Length, intersections);
        }

        internal static int solution(int[] A)
        {
            long result = 0;
            Dictionary<long, int> diskPointStart = new Dictionary<long, int>();
            Dictionary<long, int> diskPointEnd = new Dictionary<long, int>();

            for (int i = 0; i < A.Length; i++)
            {
                Inc(diskPointStart, Math.Max(0, i - A[i]));
                Inc(diskPointEnd, Math.Min(A.Length - 1, i + A[i]));
            }

            long t = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int value;
                if (diskPointStart.TryGetValue(i, out value))
                {
                    result += t * value;
                    result += value * (value - 1) / 2;
                    t += value;
                    if (result > 10000000)
                        return -1;
                }
                diskPointEnd.TryGetValue(i, out value);
                t -= value;
            }

            return (int)result;
        }

        internal static void Inc(Dictionary<long, int> values, long index)
        {
            int value;
            values.TryGetValue(index, out value);
            values[index] = ++value;
        }
    }
}
