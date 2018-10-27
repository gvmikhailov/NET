using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Foursquares foursquare1 = new Foursquares(12.4);
            foursquare1.PrintSideSize();
            foursquare1.PrintPerimeter();
            foursquare1.PrintSquare();

            Foursquares foursquare2 = new Foursquares(-10.3);
            foursquare2.PrintSideSize();
            foursquare2.PrintPerimeter();
            foursquare2.PrintSquare();
        }
    }
}
