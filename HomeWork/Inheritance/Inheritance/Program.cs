using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/28/2013_07_21_nasledovanie_v_si-sharp_konstruktor_bazovogo_klassa.html

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(10, 10, 20, 30, 40);
            Circle circle1 = new Circle(20, 20, 10);
            triangle1.DrawTriangle();
            circle1.DrawCircle();
        }
    }
}
