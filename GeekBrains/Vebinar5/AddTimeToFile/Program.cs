using System;
using System.IO;

namespace AddTimeToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = $"{DateTime.Now.ToString("hh:mm:ss")} \r\n" ;
            string path = @"D:\Store\Coding\NET\startup.txt";
            AddInfoToFile(date, path);
        }

        static void AddInfoToFile(string info, string path)
        {
            using (FileStream fstream = new FileStream(path, FileMode.Append))
            {
                byte[] infoArray = System.Text.Encoding.Default.GetBytes(info);
                fstream.Write(infoArray, 0, infoArray.Length);
                Console.WriteLine("Дата добавлена в файл");
            }
            Console.ReadKey();
        }
    }
}
