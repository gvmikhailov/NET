using System;

namespace Vebinar7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScorePathRecursion(10, 10));
            Console.WriteLine(ScorePath(10, 10));
            Console.ReadKey();
        }

        public static int ScorePath(int width, int height)
        {
            int[,] matrix = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                    }
                }
            }

            return matrix[width - 1, height - 1];
        }

        public static int ScorePathRecursion(int width, int height) // Так, на всякий случай для проверки
        {
            if (width == 1 || height == 1) return 1;

            return ScorePathRecursion(width - 1, height) + ScorePathRecursion(width, height - 1);
        }
    }
}
