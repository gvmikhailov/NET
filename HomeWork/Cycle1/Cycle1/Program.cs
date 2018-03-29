using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/11/2013_04_25_cikly_v_si-sharp_operatory_break_i_continue.html

namespace Cycle1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRow = - 2;
            for (int i = 0; i < 20; i++)
            {
                numberOfRow += 3;
                Console.Write(numberOfRow + ", ");
            }
        }
    }
}
