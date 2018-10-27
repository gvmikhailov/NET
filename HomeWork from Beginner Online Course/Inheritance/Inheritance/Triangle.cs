using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Triangle : GeometricFigure
    {
        public int Mediana1 { get; set; }
        public int Mediana2 { get; set; }
        public int Mediana3 { get; set; }
        public Triangle (int centerX, int centerY, int mediana1, int mediana2, int mediana3) : base(centerX, centerY)
        {
            Mediana1 = mediana1;
            Mediana2 = mediana2;
            Mediana3 = mediana3;
        }
        public void DrawTriangle()
        {
            Console.WriteLine("Нарисовали треугольник с центром ({0}:{1}) и медианами {2}, {3}, {4}", CenterX, CenterY,Mediana1,Mediana2,Mediana3);
        }
    }
}
