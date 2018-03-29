using System;
using System.Collections.Generic;


namespace GeometricalFigureSquare
{
    public class FigureSquare
    {
        public static double GetSquare(double radius)
        {
            double circleSqure = 0;
            if (radius < 0)
            {
                circleSqure = -1;
                Console.WriteLine("Не допускается введение отрицательных значений для радиуса окружности!");
            }
            else
            {
                circleSqure = Math.Round((Math.Pow(radius, 2) * Math.PI), 2);
            }
            return circleSqure;
        }

        public static double GetSquare(double side1, double side2, double side3)
        {
            double rightTriangleSquare = 0;
            List<double> triangeSides = new List<double>() { side1, side2, side3 };
            triangeSides.Sort();
            if (triangeSides[0] < 0 || triangeSides[1] < 0 || triangeSides[2] < 0)
            {
                rightTriangleSquare = -1;
                Console.WriteLine("Не допускается введение отрицательных значений для сторон треугольника!");
            }
            else
            {
                triangeSides.RemoveAt(2);
                rightTriangleSquare = Math.Round((triangeSides[0] * triangeSides[1]) / 2, 2);
            }
            return rightTriangleSquare;
        }

        public static int GetSquare(int someside1, int someside2)
        {
            int someSqure = 0;
            if (someside1 < 0 || someside2 < 0)
            {
                someSqure = -1;
                Console.WriteLine("Не допускается введение отрицательных значений для строн фигуры!");
            }
            else
            {
                someSqure = 10;
            }
            return someSqure;
        }
    }
}
