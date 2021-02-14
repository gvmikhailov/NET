using System;
using System.Collections.Generic;
using System.Linq;

namespace Vebinar8
{
    public static class Heep
    {
        public static void BucketSort(int[] array)
        {
            int MaxValue = array[0];
            int MinValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (MaxValue < array[i])
                    MaxValue = array[i];

                if (MinValue > array[i])
                    MinValue = array[i];
            }

            List<int>[] bucket = new List<int>[(MaxValue - MinValue) + 1];

            for (int s = 0; s < bucket.Length; s++)
            {
                bucket[s] = new List<int>();
            }

            for (int b = 0; b < array.Length; b++)
            {
                bucket[array[b] - MinValue].Add(array[b]);
            }

            for (int m = 0; m < bucket.Length; m++)
            {
                if (bucket[m].Count > 0)
                {
                    for (int n = 0; n < bucket[m].Count; n++)
                    {
                        int w = n;

                        while (w != 0)
                        {
                            MergeSort.MergeSortArray(bucket[m]);
                            w = w - 1;
                        }
                    }
                }
            }

            int q = 0;
            for (int e = 0; e < bucket.Length; e++)
            {
                if (bucket[e].Count > 0)
                {
                    for (int f = 0; f < bucket[e].Count; f++)
                    {
                        array[q] = bucket[e][f];
                        q++;
                    }
                }
            }
        }
    }
}
