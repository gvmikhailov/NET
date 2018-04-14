using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circles circle1 = new Circles(11.22, 12, 15);
            circle1.PrintCenterCoordinates();
            circle1.PrintRadius();
            circle1.PrintSquare();
            circle1.PrintCircuit();

            Circles circle2 = new Circles(17.01, 0, -1);
            circle2.PrintCenterCoordinates();
            circle2.PrintRadius();
            circle2.PrintSquare();
            circle2.PrintCircuit();
        }
    }
}
