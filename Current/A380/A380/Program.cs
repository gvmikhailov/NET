using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1893

namespace A380
{
    class Program
    {
        static void Main(string[] args)
        {
            string seatHigh = string.Empty;
            string seatBussiness = string.Empty;
            string seatEconom = string.Empty;
            string seat = string.Empty;
            Console.WriteLine("Введите номер ряда (От 1 до 65)");
            int row = Int32.Parse(Console.ReadLine());
            if (row <= 2)
            {
                Console.WriteLine("Введите место (от A до D");
                seatHigh = Console.ReadLine();
                seat = seatHigh;
            }
            if (row > 2 && row < 21)
            {
                Console.WriteLine("Введите место (от A до F)");
                seatBussiness = Console.ReadLine();
                seat = seatBussiness;
            }
            if (row > 21 && row < 66)
            {
                Console.WriteLine("Введите место (от A до K, исключая I)");
                seatEconom = Console.ReadLine();
                seat = seatEconom;
            }
            Console.WriteLine("Вы выбрали место: " + row + " " + seat);
            PrintPlaceLocation(row, seat);
        }
        static void PrintPlaceLocation (int row, string seat)
        {
            if (row <= 2 && (seat == "A" || seat == "D"))
            {
                Console.WriteLine("Вы выбрали место у окна и прохода");
            }
            else if ((row <= 2) && (seat == "B" || seat == "C") || (row > 2 && row < 21) && (seat == "B" || seat == "C" || seat == "D" || seat == "E") || (row > 21 && row < 66) && (seat == "G" || seat == "C" || seat == "D" || seat == "H"))
            {
                Console.WriteLine("Вы выбрали место у прохода");
            }
            else if ((row > 2 && row < 21) && (seat == "A" || seat == "F") || (row > 21 && row < 66) && (seat == "A" || seat == "K"))
            {
                Console.WriteLine("Вы выбрали место у окна");
            }
            else
            {
                Console.WriteLine("Ваше место ни у окна ни у прохода, либо такого места не существует");
            }
        }
    }
}
