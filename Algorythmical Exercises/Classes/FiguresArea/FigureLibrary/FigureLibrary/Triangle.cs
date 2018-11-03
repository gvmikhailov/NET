using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FigureLibrary
{
    public class Triangle : IFigure
    {
        private List<double> sides = new List<double>(3);

        private double _sideA;
        private double _sideB;
        private double _sideC;

        [Required]
        [Range(0, double.MaxValue)]
        public double SideA
        {
            set
            {
                _sideA = value;
                sides.Add(_sideA);
            }
        }

        [Required]
        [Range(0, double.MaxValue)]
        public double SideB
        {
            set
            {
                _sideB = value;
                sides.Add(_sideB);
            }
        }

        [Required]
        [Range(0, double.MaxValue)]
        public double SideC
        {
            set
            {
                _sideC = value;
                sides.Add(_sideC);
            }
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
