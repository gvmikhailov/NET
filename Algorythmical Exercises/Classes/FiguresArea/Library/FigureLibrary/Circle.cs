using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    public class Circle : IFigure
    {
        private double _radius;

        private double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Значение радиуса не может быть отрицательным!");
                    _radius = -1;
                }
                else if(value > double.MaxValue)
                {
                    Console.WriteLine("Значение радиуса превышает допустимое значение!");
                    _radius = -1;
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            if (Radius == -1)
            {
                return -1;
            }
            else
            {
                double area;
                return area = Math.Round((Math.Pow(Radius, 2) * Math.PI), 2);
            }            
        }
    }
}
