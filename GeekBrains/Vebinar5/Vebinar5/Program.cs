using System;
using System.IO;

namespace Vebinar5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию и нажмите Enter:");
            string info = Console.ReadLine();
            string path = @"D:\Store\Coding\NET\veb5.txt";
            WriteToFile(info, path);          
        }

        static void WriteToFile (string info, string path)
        {
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] infoArray = System.Text.Encoding.Default.GetBytes(info);
                fstream.Write(infoArray, 0, infoArray.Length);
                Console.WriteLine("Информация записана в файл");
            }
            Console.ReadKey();
        }
    }
}
