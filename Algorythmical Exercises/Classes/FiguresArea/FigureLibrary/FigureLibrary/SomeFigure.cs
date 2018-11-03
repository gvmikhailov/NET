using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FigureLibrary
{
    public class SomeFigure
    {
        [Required]
        [Range(0, double.MaxValue)]
        public double SideA { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double SideB { get; set; } 

        public double GetArea()
        {
            double area;
            return area = SideA * SideB + SideA; // some code to calculete area
        }
    }
}
