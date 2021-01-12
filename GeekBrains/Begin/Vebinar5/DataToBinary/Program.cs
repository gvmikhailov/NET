using System;
using System.IO;

namespace DataToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел в диапазоне от 0 до 255 через пробел и нажмите Enter:");
            string numberLine = Console.ReadLine();
            string path = @"D:\Store\Coding\NET\integer.dat";
            string [] numbersStringArray = numberLine.Split(' ');
            int [] numbersIntArray = new int[numbersStringArray.Length];
            int number;
            for (int i = 0; i < numbersIntArray.Length; i++)
            {
                if (Int32.TryParse(numbersStringArray[i], out number) == true && number >=0 && number <= 255 )
                {
                    numbersIntArray[i] = number;
                }
            }
            WriteNumbersToBinary(path, numbersIntArray);
        }

        static void WriteNumbersToBinary(string path, int[] numbers)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    writer.Write(numbers[i]);
                }
                Console.WriteLine("Данные добавлены в бинарный файл");
            }
            Console.ReadKey();
        }
    }
}
