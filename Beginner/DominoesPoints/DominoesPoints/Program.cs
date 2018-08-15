using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoesPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное количество точек на одной грани: ");
            long points = Int64.Parse(Console.ReadLine());
            long summPoints = 0;
            for (int i = 1; i <= points; i++)
            {
                summPoints += i;
            }
            long diamonds = (points + 2) * summPoints;
            Console.WriteLine("Для изготовления комплекта домино потребуется {0} бриллиантов", diamonds);
        }
    }
}
