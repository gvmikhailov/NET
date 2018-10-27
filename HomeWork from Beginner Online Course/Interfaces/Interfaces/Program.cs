using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TvSet tv1 = new TvSet("Sony", "Empire-3091");
            TvSet tv2 = new TvSet("Samsung", "Luminator1771");
            Light light1 = new Light("Гостинная", "Люстра");
            Light light2 = new Light("Детская", "Ночник");
            tv1.SwitchOn();
            tv2.SwitchOff();
            light1.SwitchOn();
            light2.SwitchOff();
        }
    }
}
