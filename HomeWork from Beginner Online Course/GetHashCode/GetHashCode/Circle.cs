using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode
{
    class Circle
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int Radius { get; set; }
        public Circle(int centerX, int centerY, int radius)
        {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Circle c = obj as Circle;
            if (c as Circle == null)
            {
                return false;
            }
            return c.CenterX == this.CenterX && c.CenterY == this.CenterY && c.Radius == this.Radius;
        }
        public bool Equals (Circle obj)
        {
            if (obj == null)
            { 
                return false;
            }
            return obj.CenterX == this.CenterX && obj.CenterY == this.CenterY && obj.Radius == this.Radius;
        }
        public override int GetHashCode()
        {
            return CenterX + CenterY + Radius;
        }
    }
}
