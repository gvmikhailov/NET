using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip 
{
    partial class Program
    {
        enum Deck
        {
            четырех = 1,
            трех,
            дву,
            одно
        }

        enum Score
        {
            первого,
            второго,
            третьего,
            четвертого,
        }

        static List<string> coordinates = new List<string>();

        static void TakeCoordinate ()
        {
            
            string startShip = String.Empty;
            string endShip = String.Empty;
            for (int i = 0; i < 4; i--)
            {
                for (int j = 0; j < (i+1); j++)
                {
                    Console.WriteLine($"Вводим координаты {(Deck)(i+1)}палубного корабля:");
                    do
                    {
                        Console.WriteLine($"Введите начальную координату {(Score)j} корабля");
                        startShip = Console.ReadLine();
                        if (!CheckCoordinate(startShip))
                            continue;
                    }
                    while (CheckCoordinate(startShip) == true);
                    do
                    {
                        Console.WriteLine($"Введите конечную координату {(Score)j} корабля");
                        endShip = Console.ReadLine();
                        if (!CheckCoordinate(startShip))
                            continue;
                    }
                    while (CheckCoordinate(startShip) == true);
                    AddCoordinate(startShip, endShip, (Deck)(i+1));
                }                
            }

            for (int i = 0; i < (int)Deck.четырех; i++)
            {
                do
                {
                    Console.WriteLine($"Введите координату {(Score)i} однопалубного корабля");
                    startShip = Console.ReadLine();
                    if (CheckCoordinate(startShip))
                        coordinates.Add(startShip);
                    else
                        continue;
                }
                while (CheckCoordinate(startShip) == true);
            }
        }

        static bool CheckCoordinate(string coordinate)
        {
            string str = String.Empty;
            if (coordinate.Length > 3 || !coordinate.Contains(coordinate[0]) || !coordinate.Contains(str = coordinate.Length == 3 ? (coordinate[1] + coordinate[2]).ToString() : coordinate[1].ToString()))
            {
                Console.WriteLine("Неверная координата!");
                return false;
            }
            else
                return true;
        }

        static void AddCoordinate(string start, string end, Deck deck)
        {
            int endC = (int)deck - 2;
            if (start[0] == end[0])
            {
                coordinates.Add(start);
                for (int i = 0; i < endC; i++)
                {
                    coordinates.Add(start[0] + (Int32.Parse(start[1].ToString()) + (i + 1)).ToString());
                }
                coordinates.Add(end);
            }
            else
            {
                coordinates.Add(start);
                for (int i = 0; i < endC; i++)
                {
                    coordinates.Add(letters[Array.IndexOf(letters, start[0]) + (i+1)].ToString() + (start.Length == 3 ? (start[1] + start[2]).ToString() : start[1].ToString()));
                }
                coordinates.Add(end);
            }
        }
    }
}
