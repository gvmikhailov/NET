using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    class Plant
    {
        public string Name { get; set; }
        public string Species { get; set; }

        internal Plant (string name, string species)
        {
            Name = name;
            Species = species;
        }

        internal virtual void PrintPlantInfo()
        {
            Console.WriteLine("Растение {0} вида {1}", Name, Species);
        }
    }
}
