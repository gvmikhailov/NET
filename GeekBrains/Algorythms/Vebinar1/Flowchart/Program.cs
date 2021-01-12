using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckSimpleNumber(17)? "Простое": "Не простое");
        }

        static bool CheckSimpleNumber(int number)
        {
            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number%i == 0)
                {
                    d++;
                }

                i++;                                        
            }

            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
