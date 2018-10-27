using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    class Flower : Plant
    {
        private double _height;

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    _height = Math.Round(Program.rnd.Next(0, 6) + Program.rnd.NextDouble(), 2);
                    Console.WriteLine("Высота стебля цветка не может быть отрицательной или больше 6 метров - установлено {0} м.", _height);
                }
                else
                {
                    _height = value;
                }
            }
        }

        internal Flower(string name, string species, double height) : base(name, species)
        {
            Height = height;
        }

        internal new void PrintPlantInfo()
        {
            Console.WriteLine("Цветок {0} вида {1}, c длиной стебля {2} м.", Name, Species, Height);
        }
    }
}
