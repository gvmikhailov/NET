using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangles rectangle1 = new Rectangles(12.5, 10.2);
            rectangle1.GetHeight();
            rectangle1.GetWidth();
            rectangle1.GetSquare();
            rectangle1.GetPerimeter();
        }
    }
}
