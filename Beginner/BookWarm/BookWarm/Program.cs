using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1638

namespace BookWarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int depthBook = rnd.Next(50, 101);
            Console.WriteLine("Толщина книги - {0} мм", depthBook);
            int depthBinding = rnd.Next(2, 11);
            Console.WriteLine("Толщина переплета - {0} мм", depthBinding);
            int volumeNumberStart = rnd.Next(1, 100);
            Console.WriteLine("Номер тома, с первого листа которого червяк начал свой путь - {0}", volumeNumberStart);
            int volumeNumberFinish = rnd.Next(1, 101);
            Console.WriteLine("Номер тома, на последнем листе которого он остановился - {0}", volumeNumberFinish);
            GetPath(depthBook, depthBinding, volumeNumberStart, volumeNumberFinish);
        }
        static void GetPath (int depthBook, int depthBinding, int volumeNumberStart, int volumeNumberFinish)
        {
            if (volumeNumberStart < volumeNumberFinish)
            {
                int volumeNumbersFull = volumeNumberFinish - volumeNumberStart - 1;
                int numberOfBindings = volumeNumbersFull * 2 + 2;
                int allPath = (volumeNumbersFull * depthBook) + (numberOfBindings * depthBinding);
                Console.WriteLine("Длина пути, прогрызенного червяком {0} мм.", allPath);
            }
            else if (volumeNumberStart > volumeNumberFinish)
            {
                int volumeNumbersFull = volumeNumberStart - volumeNumberFinish + 1;
                int numberOfBindings = (volumeNumberStart - volumeNumberFinish) * 2;
                int allPath = (volumeNumbersFull * depthBook) + (numberOfBindings * depthBinding);
                Console.WriteLine("Длина пути, прогрызенного червяком {0} мм.", allPath);
            }
            else
            {
                int allPath = depthBook;
                Console.WriteLine("Длина пути, прогрызенного червяком {0} мм.", allPath);
            }
        }
    }
}
