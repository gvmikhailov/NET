using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class TvSet : ISwitchable
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public TvSet (string manufacturer, string model)
        {
            Manufacturer = manufacturer;
            Model = model;
        }
        public void SwitchOn()
        {
            Console.WriteLine("Телевизор {0} - {1} включен", Manufacturer, Model);
        }
        public void SwitchOff()
        {
            Console.WriteLine("Телевизор {0} - {1} выключен", Manufacturer, Model);
        }
    }
}
