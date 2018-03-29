using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GeometricFigure
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public GeometricFigure (int centerX, int centerY)
        {
            CenterX = centerX;
            CenterY = centerY;
        }
    }
}
