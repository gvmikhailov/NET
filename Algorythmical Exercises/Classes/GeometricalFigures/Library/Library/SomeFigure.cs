using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SomeFigure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }

        public SomeFigure (double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public double GetArea()
        {
            double area;
            return area = SideA * SideB + SideA; // some code to calculete area
        }

    }
}
