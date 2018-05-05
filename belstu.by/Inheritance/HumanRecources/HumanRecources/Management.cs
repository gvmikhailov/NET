using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRecources
{
    class Management : Employee
    {
        public string Position { get; set; }

        internal Management (string name, string position) : base (name)
        {
            Position = position;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Работник администрации {0} на должности {1}", Name, Position);
        }
    }
}
