using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://app.codility.com/programmers/task/number_of_disc_intersections/

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
            int intersections = GetNumbersOfIntersects(middlePoints);
            Console.WriteLine("Кругов - {0}\nИз них пересекаются - {1}", middlePoints.Length, intersections);
        }

        static int GetNumbersOfIntersects(int[] A)
        {
            List<long> leftBorder = new List<long>();
            List<long> rightBorder = new List<long>();
            for (int i = 0; i < A.Length; i++)
            {
                leftBorder.Add(i - (long)A[i]);
                rightBorder.Add(i + (long)A[i]);
            }
            leftBorder.Sort();
            rightBorder.Sort();
            int counter = 0;
            int startIndex = 0;
            for (int j = 0; j < A.Length - 1; j++)
            {
                while (startIndex < leftBorder.Count && leftBorder[startIndex] <= rightBorder[j])
                {
                    startIndex += 1;
                }
                counter += startIndex - j - 1;
                if (counter > 10000000)
                {
                    return -1;
                }
            }
            return counter;
        }
    }
}
