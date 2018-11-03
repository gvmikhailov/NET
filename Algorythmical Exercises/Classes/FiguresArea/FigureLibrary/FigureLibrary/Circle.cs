using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FigureLibrary
{
    public class Circle : IFigure
    {
        [Required]
        [Range(0, double.MaxValue)]
        public double Radius { get; set; }

        public double GetArea()
        {
            double area;
            return area = Math.Round((Math.Pow(Radius, 2) * Math.PI), 2);
        }
    }
}
