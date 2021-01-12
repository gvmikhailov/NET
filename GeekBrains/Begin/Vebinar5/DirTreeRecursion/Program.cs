using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DirTreeRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDir = @"D:\Store\Coding\NET\";
            string path = @"D:\Store\Coding\NET\dir.txt";
            StringBuilder sb = new StringBuilder(String.Empty);
            string result = PrintTree(sb, startDir);
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] infoArray = System.Text.Encoding.Default.GetBytes(result);
                fstream.Write(infoArray, 0, infoArray.Length);
            }
            Console.WriteLine("Дерево каталогов успешно сохранено.");
            Console.ReadKey();
        }

        static string PrintTree(StringBuilder sb, string startDir, string prefix = "")
        {
            DirectoryInfo dir = new DirectoryInfo(startDir);
            var fsItems = dir.GetFileSystemInfos()
                .Where(f => !f.Name.StartsWith("."))
                .OrderBy(f => f.Name)
                .ToList();

            for (int i = 0; i < fsItems.Count; i++)
            {
                if (i == fsItems.Count - 1)
                {
                    sb.Append(prefix + "└── ");
                    sb.Append(fsItems[i]);
                    sb.Append("\r\n");
                    if ((fsItems[i].Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        PrintTree(sb, fsItems[i].FullName, prefix + "    ");
                    }
                }
                else
                {
                    sb.Append(prefix + "├── ");
                    sb.Append(fsItems[i]);
                    sb.Append("\r\n");
                    if ((fsItems[i].Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        PrintTree(sb, fsItems[i].FullName, prefix + "│   ");
                    }
                }
            }
            return sb.ToString();
        }
    }
}

