using System;

namespace Vebinar3
{
    public class Arrays
    {
        static Random rnd = new Random();

        public static int[] pointsX { get; set; } = new int[20];
        public static int[] pointsY { get; set; } = new int[20];

        public Arrays(int[] x, int[] y)
        {
            pointsX = ArrayFill(x);
            pointsY = ArrayFill(y);
        }

        public static int[] ArrayFill(int[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = rnd.Next(20, 101);
            }

            return points;
        }
    }
}
