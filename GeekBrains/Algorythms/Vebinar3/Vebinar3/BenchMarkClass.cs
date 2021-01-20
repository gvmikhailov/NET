using System;
using BenchmarkDotNet.Attributes;

namespace Vebinar3
{
    public class BenchMarkClass
    {
        Arrays array = new Arrays(Arrays.pointsX, Arrays.pointsY);

        public void GetPointClassFloatDistance()
        {
            for (int i = 0; i < Arrays.pointsX.Length - 1 ; i++)
            {
                PointClass point1 = new PointClass(Arrays.pointsX[i], Arrays.pointsY[i]);
                PointClass point2 = new PointClass(Arrays.pointsX[i+1], Arrays.pointsY[i+1]);
                float x = point1.X - point2.X;
                float y = point1.Y - point2.Y;
                float distance =  (float)Math.Sqrt((x * x) + (y * y));
            }
        }

        public void GetPointStructFloatDistance()
        {
            for (int i = 0; i < Arrays.pointsX.Length - 1; i++)
            {
                PointStruct point1 = new PointStruct(Arrays.pointsX[i], Arrays.pointsY[i]);
                PointStruct point2 = new PointStruct(Arrays.pointsX[i + 1], Arrays.pointsY[i + 1]);
                float x = point1.X - point2.X;
                float y = point1.Y - point2.Y;
                float distance = (float)Math.Sqrt((x * x) + (y * y));
            }
        }

        public void GetPointStructDoubleDistance()
        {
            for (int i = 0; i < Arrays.pointsX.Length - 1; i++)
            {
                PointStruct point1 = new PointStruct(Arrays.pointsX[i], Arrays.pointsY[i]);
                PointStruct point2 = new PointStruct(Arrays.pointsX[i + 1], Arrays.pointsY[i + 1]);
                double x = point1.X - point2.X;
                double y = point1.Y - point2.Y;
                double distance = Math.Sqrt((x * x) + (y * y));
            }
        }

        public void GetPointStructFloatDistanceWOSqrt()
        {
            for (int i = 0; i < Arrays.pointsX.Length - 1; i++)
            {
                PointStruct point1 = new PointStruct(Arrays.pointsX[i], Arrays.pointsY[i]);
                PointStruct point2 = new PointStruct(Arrays.pointsX[i + 1], Arrays.pointsY[i + 1]);
                float x = point1.X - point2.X;
                float y = point1.Y - point2.Y;
                float distance = (x * x) + (y * y);
            }
        }

        [Benchmark]
        public void GetPointClassFloatDistanceTest()
        {
            GetPointClassFloatDistance();
        }

        [Benchmark]
        public void GetPointStructFloatDistanceTest()
        {
            GetPointStructFloatDistance();
        }

        [Benchmark]
        public void GetPointStructDoubleDistanceTest()
        {
            GetPointStructDoubleDistance();
        }

        [Benchmark]
        public void GetPointStructFloatDistanceWOSqrtTest()
        {
            GetPointStructFloatDistanceWOSqrt();
        }
    }
}
