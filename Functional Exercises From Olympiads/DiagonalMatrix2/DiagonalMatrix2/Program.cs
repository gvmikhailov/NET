using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 8; // Задание размера массива arraySize х arraySize
            int[,] massiv = new int[arraySize, arraySize];
            int count = 1;
            int k = 1;
            for (int j = 0; j < arraySize; j++)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    massiv[i, j] = k;
                    k++;
                    Console.Write("{0,3}", massiv[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int x = arraySize; x >= 0; x--)
            {
                int y = 0;
                int xx = x;
                bool exc = false;
                while (!exc)
                {
                    try
                    {
                        massiv[xx, y] = count;
                        count++;
                        xx++;
                        y++;
                    }
                    catch
                    {
                        exc = true;
                        break;
                    }
                }
            }

            for (int y = 1; y <= arraySize - 1; y++)
            {
                int x = 0;
                int yy = y;
                bool exc = false;
                while (!exc)
                {
                    try
                    {
                        massiv[x, yy] = count;
                        count++;
                        x++;
                        yy++;
                    }
                    catch
                    {
                        exc = true;
                        break;
                    }
                }
            }

            for (int x = 0; x < arraySize; x++)
            {
                for (int y = 0; y < arraySize; y++)
                {
                    Console.Write("{0,3}", massiv[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
