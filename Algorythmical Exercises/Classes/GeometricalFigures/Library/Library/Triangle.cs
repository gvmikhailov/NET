using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Triangle : IFigure
    {
        private List<double> sides = new List<double>(3);

        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            sides.Add(SideA = sideA);
            sides.Add(SideB = sideB);
            sides.Add(SideC = sideC);
        }

        public double GetArea()
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
    }
}
