using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLast2
{
    class SomeClass
    {
        public int SomeInt { get; set; }
        public string SomeString { get; set; }

        public SomeClass (int someInt, string someString)
        {
            SomeInt = someInt;
            SomeString = someString;
        }

        public override string ToString()
        {
            return "SomeclassObj: " + SomeInt + " " + SomeString;
        }
    }
}
