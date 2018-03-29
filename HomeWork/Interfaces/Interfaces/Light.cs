using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Light : ISwitchable
    {
        public string Location { get; set; }
        public string Type { get; set; }

        public Light(string location, string type)
        {
            Location = location;
            Type = type;
        }
        public void SwitchOn()
        {
            Console.WriteLine("Свет {0} в {1} включен", Type, Location);
        }
        public void SwitchOff()
        {
            Console.WriteLine("Свет {0} в {1} выключен", Type, Location);
        }
    }
}
