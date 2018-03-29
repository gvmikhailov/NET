using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Englishman : Human
    {
        public Englishman (string name) : base(name)
        {
        }
        public override void SayHello()
        {
            Console.WriteLine("Британец говорит Hi!");
        }
    }
}
