using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare
{
    class Foursquares
    {
        private double _side;

        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Сторона квадрата не может быть нулевой или отрицательной! Установлено значение 1");
                    _side = 1;
                }
                else
                {
                    _side = value;
                }
            }
        }

        internal Foursquares (double size)
        {
            Side = size;
        }

        internal void PrintSideSize()
        {
            Console.WriteLine("Сторона квадрата - {0}", Side);
        }

        internal void PrintPerimeter ()
        {
            Console.WriteLine("Периметр квадрата со стороной {0} - {1}", Side, Side * 4);
        }

        internal void PrintSquare ()
        {
            Console.WriteLine("Площадь квадрата со стороной {0} - {1}", Side, Math.Round(Math.Pow(Side, 2), 2));
        }
    }
}
