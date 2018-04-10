using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circles
    {
        private double _radius;
        private int _centerX;
        private int _centerY;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Не допускается нулевое или отрицательное значение для радиуса! Установлено значение 1");
                    _radius = 1;
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public int CenterX
        {
            get
            {
                return _centerX;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Не допускается нулевое или отрицательное значение для координаты Х центра окружности! Установлено значение 1");
                    _centerX = 1;
                }
                else
                {
                    _centerX = value;
                }
            }
        }

        public int CenterY
        {
            get
            {
                return _centerY;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Не допускается нулевое или отрицательное значение для координаты Y центра окружности! Установлено значение 1");
                    _centerY = 1;
                }
                else
                {
                    _centerY = value;
                }
            }
        }

        internal Circles (double radius, int centerX, int centerY)
        {
            Radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }

        internal void PrintSquare ()
        {
            Console.WriteLine("Площадь круга - {0}", Math.Round((Math.Pow(Radius,2) * Math.PI), 2));
        }

        internal void PrintCircuit()
        {
            Console.WriteLine("Длина окружности - {0}", Math.Round(2*Math.PI*Radius, 2), 2);
        }

        internal void PrintRadius ()
        {
            Console.WriteLine("Радиус окружности - {0}", Radius);
        }

        internal void PrintCenterCoordinates()
        {
            Console.WriteLine("Координаты центра окружности - [{0},{1}] ", CenterX, CenterY);
        }
    }
}
