using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание квадратичного массива, заполнение его и перестроение по диагонали.

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 8; // Задание размера массива arraySize х arraySize
            int[,] massiv = new int[arraySize, arraySize];
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    massiv[i, j] = rnd.Next(0, 100);
                    Console.Write("{0,3}", massiv[i, j]); // Выделение при печати места под три дигита  
                }
                Console.WriteLine();
            }
            Console.WriteLine("Перестроенный массив:");
            for (int i = 0; i < arraySize; i++)
            {
                int x = i, y = 0;
                while (x >= 0 && x <= arraySize)
                {
                    Console.Write(massiv[x, y] + " ");
                    x--;
                    y++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arraySize; i++)
            {
                int x = arraySize - 1, y = i + 1;
                while (y >= 1 && y < arraySize)
                {
                    Console.Write(massiv[x, y] + " ");
                    x--;
                    y++;
                }
            }
            Console.WriteLine();
        }
    }
}
