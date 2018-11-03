using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Circle : IFigure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            double area;
            return area = Math.Round((Math.Pow(Radius, 2) * Math.PI), 2);
        }
    }
}
