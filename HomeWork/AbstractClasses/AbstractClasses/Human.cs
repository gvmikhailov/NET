using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Human
    {
        public string Name { get; set; }
        public Human (string name)
        {
            Name = name;
        }
        public abstract void SayHello();
    }
}
