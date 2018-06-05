using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGU
{
    class Faculties : bgtu
    {
        public string Faculty { get; set; }

        internal Faculties (string address, string faculty) : base (address)
        {
            Faculty = faculty;
        }

        internal new void PrintInfo ()
        {
            Console.WriteLine("Факульет: {0}", Faculty);
        }
    }
}
