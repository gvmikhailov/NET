using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fullFilesPath = Directory.GetFiles(@"D:\Store\Coding\NET\", "*.*", SearchOption.AllDirectories);
            string[] fullDirectoriesPath = Directory.GetDirectories(@"D:\Store\Coding\NET\", "*.*", SearchOption.AllDirectories);
            string path = @"D:\Store\Coding\NET\dirtree.txt";
            StringBuilder sb = new StringBuilder(String.Empty);
            sb.Append("Files:\r\n");
            for (int i = 0; i < fullFilesPath.Length; i++)
            {
                sb.Append(fullFilesPath[i]);
                sb.Append("\r\n");
            }
            sb.Append("Directories:\r\n");
            for (int i = 0; i < fullDirectoriesPath.Length; i++)
            {
                sb.Append(fullDirectoriesPath[i]);
                sb.Append("\r\n");
            }
            string result = sb.ToString();
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] infoArray = System.Text.Encoding.Default.GetBytes(result);
                fstream.Write(infoArray, 0, infoArray.Length);
            }
            Console.WriteLine("Дерево каталогов успешно сохранено.");
            Console.ReadKey();
        }
    }
}

