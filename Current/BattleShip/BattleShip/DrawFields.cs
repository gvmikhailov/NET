using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class DrawFields
    {
        public static void Draw2Fields()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write('\u2014');
            }            
        }
    }
}
