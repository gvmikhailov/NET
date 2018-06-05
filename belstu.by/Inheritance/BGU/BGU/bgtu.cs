using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGU
{
    class bgtu
    {
        public string Address { get; set; }

        internal bgtu (string address)
        {
            Address = address;
        }

        internal void PrintInfo ()
        {
            Console.WriteLine("Адрес БГТУ: {0}", Address);
        }
    }
}
