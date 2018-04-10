using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangles
    {
        private double _height;
        private double _width;

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Высота прямоугольника не может быть отрицательной или 0, установлено значение 1");
                    _height = 1;
                }
                else
                {
                    _height = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина прямоугольника не может быть отрицательной или 0, установлено значение 1");
                    _width = 1;
                }
                else
                {
                    _width = value;
                }
            }
        }

        internal Rectangles (double height, double width)
        {
            Height = height;
            Width = width;
        }

        internal void GetHeight()
        {
            Console.WriteLine("Высота прямоугольника - {0}", Math.Round(Height, 2));
        }

        internal void GetWidth()
        {
            Console.WriteLine("Ширина прямоугольника - {0}", Math.Round(Width, 2));
        }

        internal void GetSquare()
        {
           Console.WriteLine("Площадь прямоугольника - {0}", Math.Round((Height * Width), 2));
        }

        internal void GetPerimeter()
        {
            Console.WriteLine("Периметр прямоугольника - {0}", Math.Round((Height + Width) * 2, 2));
        }
    }
}
