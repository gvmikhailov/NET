using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            TvSet volume = new TvSet();
            volume.Volume = rnd.Next(-100, 301);
            Console.WriteLine(volume.Volume);
        }
    }
}
