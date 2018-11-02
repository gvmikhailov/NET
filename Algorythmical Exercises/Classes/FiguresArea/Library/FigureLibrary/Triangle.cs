using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    public class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        private List<double> sides = new List<double>(3);

        private double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение стороны треугольника не может быть отрицательным!");
                    _sideA = -1;
                }
                else if (value > double.MaxValue)
                {
                    Console.WriteLine("Значение стороны треугольника превышает допустимое значение!");
                    _sideA = -1;
                }
                else
                {
                    _sideA = value;
                    sides.Add(_sideA);
                }
            }
        }

        private double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение стороны треугольника не может быть отрицательным!");
                    _sideB = -1;
                }
                else if (value > double.MaxValue)
                {
                    Console.WriteLine("Значение стороны треугольника превышает допустимое значение!");
                    _sideB = -1;
                }
                else
                {
                    _sideB = value;
                    sides.Add(_sideB);
                }
            }
        }

        private double SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение стороны треугольника не может быть отрицательным!");
                    _sideC = -1;
                }
                else if (value > double.MaxValue)
                {
                    Console.WriteLine("Значение стороны треугольника превышает допустимое значение!");
                    _sideC = -1;
                }
                else
                {
                    _sideC = value;
                    sides.Add(_sideC);
                }
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {                            
            sides.Sort();
            double area;
            if (SideA == -1 || SideB == -1 || SideC == -1)
            {
                return -1;
            }
            else if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2) && sides.Count == 3)
            {
                return area = Math.Round((sides[0] * sides[1]) / 2, 2);
            }
            else
            {
                double p = (SideA + SideB + SideC) / 2;
                return area = Math.Round(Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 2);
            }        
        }
    }
}

