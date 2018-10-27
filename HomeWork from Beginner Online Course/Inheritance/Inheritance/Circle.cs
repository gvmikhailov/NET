using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Circle : GeometricFigure
    {
        public int Radius { get; set; }
        public Circle (int centerX, int centerY, int radius) : base(centerX,centerY)
        {
            Radius = radius;
        }
        public void DrawCircle()
        {            
            Console.WriteLine("Нарисовали окружность с ценром ({0}:{1}) и радиусом {2}", CenterX, CenterY, Radius);
        }
    }
}
