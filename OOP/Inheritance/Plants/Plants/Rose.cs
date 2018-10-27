using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    class Rose : Flower
    {
        public string Colour { get; set; }

        internal Rose(string name, string species, double height, string colour) : base(name, species, height)
        {
            Colour = colour;
        }

        internal new void PrintPlantInfo()
        {
            Console.WriteLine("Роза {0} вида {1}, c длиной стебля {2} м. и цветом {3}", Name, Species, Height, Colour);
        }
    }
}
