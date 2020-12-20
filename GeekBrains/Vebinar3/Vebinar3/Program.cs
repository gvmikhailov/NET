using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            int demension = rnd.Next(3, 10);
            Console.WriteLine($"Размерность массива {demension} x {demension}");
            int[,] array = new int[demension, demension];

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = rnd.Next(1, 10);
                    Console.Write($"{array[i,j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Диагональ массива:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write($"{array[i, j]}");
                    else
                        Console.Write(" "); // continue
                }
                Console.WriteLine(); // without Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}
