using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    public class Triangle : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        private List<double> sides = new List<double>(3);

        public double SideA
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
                }
                else if (value > double.MaxValue)
                {
                    Console.WriteLine("Значение стороны треугольника превышает допустимое значение!");
                }
                else
                {
                    _sideA = value;
                    sides.Add(_sideA);
                }
            }
        }

        public double SideB
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
                }
                else if (value > double.MaxValue)
                {
                    Console.WriteLine("Значение стороны треугольника превышает допустимое значение!");
                }
                else
                {
                    _sideB = value;
                    sides.Add(_sideB);
                }
            }
        }

        public double SideC
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
                }
                else if (value > double.MaxValue)
                {
                    Console.WriteLine("Значение стороны треугольника превышает допустимое значение!");
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
        public override double GetArea()
        {            
            try
            {
                sides.Sort();
                double area;
                if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
                {
                    return area = Math.Round((sides[0] * sides[1]) / 2, 2);
                }
                else
                {
                    double p = (sides[0] + sides[1] + sides[2]) / 2;
                    return area = Math.Round(Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2])), 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;                
            }                     
        }
    }
}

