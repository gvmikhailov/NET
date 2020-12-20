using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    partial class Program
    {

        public static string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public static char[] letters = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'к', };

        static void Main(string[] args)
        {
            Console.WriteLine("Перед расстановкой кораблей, лучше всего нарисовать их на листе!");


            string[,] battleField = new string[11, 11];
          
            for (int i = 0; i < battleField.GetLength(0); i++)
            {
                for (int j = 0; j < battleField.GetLength(1); j++)
                {
                    if (i == 0 && j > 0 && j <= 10)
                    {
                        battleField[i, j] = letters[j - 1].ToString();
                    }
                    else if (j == 0 && i > 0 && i <= 10)
                        if(i == 10)
                            battleField[i, j] = numbers[i - 1];
                        else
                            battleField[i, j] = " " + numbers[i - 1];
                    else if (i == 0 && j == 0)
                        battleField[i, j] = "  ";
                    else
                        battleField[i, j] = "0";

                    Console.Write($"{battleField[i, j]}");
                }
                Console.WriteLine();
            }

            TakeCoordinate();
            Console.Clear();
            Console.WriteLine("Расставленные корабли:");

            for (int i = 0; i < coordinates.Count; i++)
            { 
               battleField[Array.IndexOf(numbers, coordinates[i].Length == 3 ? ((coordinates[i])[1] + (coordinates[i])[2]).ToString() : (coordinates[i])[1].ToString()) + 1, Array.IndexOf(letters, coordinates[i]) + 1] = "X";
            }

            for (int i = 0; i < battleField.GetLength(0); i++)
            {
                for (int j = 0; j < battleField.GetLength(1); j++)
                {
                    if (i == 0 && j > 0 && j <= 10)
                    {
                        battleField[i, j] = letters[j - 1].ToString();
                    }
                    else if (j == 0 && i > 0 && i <= 10)
                        if (i == 10)
                            battleField[i, j] = numbers[i - 1];
                        else
                            battleField[i, j] = " " + numbers[i - 1];
                    else
                        battleField[i, j] = "  ";

                    Console.Write($"{battleField[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
