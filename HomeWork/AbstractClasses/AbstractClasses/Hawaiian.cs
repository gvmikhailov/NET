using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Hawaiian : Human
    {
        public Hawaiian(string name) : base (name)
        {
        }
        public override void SayHello()
        {
            Console.WriteLine("Гаваец говорит Aloha!");
        }
    }
}
