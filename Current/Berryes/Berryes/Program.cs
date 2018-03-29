using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=2001

namespace Berryes
{
    class Program
    {
        static void Main(string[] args)
        {
            int basketWithBerriesFirstMath = 10;
            int basketWithBerriesSecondMath = 15;
            int basketWithoutBerriesFirstMath = 3;
            int basketWithDoubleBerriesSecondMath = (basketWithBerriesFirstMath - basketWithoutBerriesFirstMath) + basketWithBerriesSecondMath;
            int basketWithoutBerriesSecondMath = 4;
            int basketWithDoubleBerriesFirstMath = (basketWithBerriesSecondMath - basketWithoutBerriesSecondMath) + basketWithBerriesFirstMath;
            int BerriesFirstMath = basketWithBerriesFirstMath - basketWithoutBerriesFirstMath;
            int BerriesSecondMath = basketWithBerriesSecondMath - basketWithoutBerriesSecondMath;
            Console.WriteLine("Ягод у первого математика: " + BerriesFirstMath + "; Ягод у второго математика: " + BerriesSecondMath);
        }
    }
}
