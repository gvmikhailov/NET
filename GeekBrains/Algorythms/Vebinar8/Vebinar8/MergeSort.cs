using System;
using System.Collections.Generic;
using System.Linq;

namespace Vebinar8
{
    public static class MergeSort
    {
        public static List<int> MergeSortArray(List<int> numbers)
        {
            if (numbers.Count == 1)
                return numbers;
            int middlePoint = numbers.Count / 2;
            return Merge(MergeSortArray(numbers.Take(middlePoint).ToList()), MergeSortArray(numbers.Skip(middlePoint).ToList()));
        }

        private static List<int> Merge(List<int> listLeft, List<int> listRight)
        {
            int left = 0;
            int right = 0;
            List<int> merged = new List<int>();
            for (int k = 0; k < listLeft.Count + listRight.Count; k++)
            {
                merged.Add(0);
            }
            for (int i = 0; i < listLeft.Count + listRight.Count; i++)
            {
                if (right < listRight.Count && left < listLeft.Count)
                {
                    if (listLeft[left] > listRight[right])
                    {
                        merged[i] = listRight[right++];
                    }
                    else
                    {
                        merged[i] = listLeft[left++];
                    }
                }
                else
                {
                    if (right < listRight.Count)
                    {
                        merged[i] = listRight[right++];
                    }
                    else
                    {
                        merged[i] = listLeft[left++];
                    }
                }
            }
            return merged;
        }
    }
}
