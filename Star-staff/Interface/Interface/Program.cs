using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricalFigureSquare;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FigureSquare.GetSquare(3, 4, 5));
            Console.WriteLine(FigureSquare.GetSquare(3));
            Console.WriteLine(FigureSquare.GetSquare(3, 4));
            Console.WriteLine(FigureSquare.GetSquare(3, 5, 5.83));
        }
    }
}
