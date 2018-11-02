using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    class SomeFigure : IFigure 
    {

        private double SideA { get; set; } // It have to be some restrictions for side
        private double SideB { get; set; } // It have to be some restrictions for side

        public SomeFigure(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public double GetArea()
        {
            double area;
            return  area = SideA * SideB + SideA; // some code to calculete area
        }
    }
}
