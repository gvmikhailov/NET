using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;


namespace ZipArchivator
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Contains("/c") && args.Length == 3)
            {
                if(args[2].EndsWith((".zip")))
                { 
                    Compress(args[1], args[2]);
                }
                else
                {
                    args[2] += ".zip";
                    Compress(args[1], args[2]);
                }
            }
            else if (args.Contains("/d") && args.Length == 2)
            {
                Decompress(args[1]);              
            }
            else
            {
                PrintHelp();
            }
        }

        static void PrintHelp()
        {
            Console.WriteLine("\nИСПОЛЬЗОВАНИЕ:\n\tZipArchivator  /? | /c Souce file Archive file | /d Archive file\nЗдесь:\n\tSource file - Путь к файлу который необходимо заархивировать\n\tArchive file - Путь к архивированному файлу\n\n\tПараметры:\n\t\t/? - Вывод данного справочного сообщения\n\t\t/c - Архивировать файл\n\t\t/d - Разархивировать файл");
        }

        static void Compress(string sourceFile, string archiveFile)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(archiveFile, ZipArchiveMode.Create))
                {
                    string destinationFile = sourceFile.Substring(sourceFile.LastIndexOf('\\') + 1);
                    string destinationFileZip = archiveFile.Substring(archiveFile.LastIndexOf('\\') + 1);
                    string directory = string.Empty;
                    if (archiveFile.Contains('\\'))
                    { 
                        directory = archiveFile.Substring(0, archiveFile.LastIndexOf('\\') + 1);
                    }
                    else
                    {
                        directory = Directory.GetCurrentDirectory();
                    }
                    archive.CreateEntryFromFile(sourceFile, destinationFile);
                    Console.Clear();
                    Console.WriteLine("Сжатие файла {0} завершено. Файл сжат в файл {1} в директории {2}\nНажмите любую кнопку...", destinationFile, destinationFileZip, directory);
                    Console.ReadKey();
                }
            }
            catch (System.IO.IOException e)
            {
                Console.Clear();
                Console.WriteLine("Ошибка архивирования!  " + e.Message + "\nНажмите любую кнопку...");
                Console.ReadKey();
            }
        }

        static void Decompress(string archiveFile)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(archiveFile, ZipArchiveMode.Read))
                {
                    string directory = string.Empty;
                    if (archiveFile.Contains('\\'))
                    { 
                        directory = archiveFile.Substring(0, archiveFile.LastIndexOf('\\') + 1);
                    }
                    else
                    {
                        directory = Directory.GetCurrentDirectory();
                    }
                    archive.ExtractToDirectory(directory);
                    Console.Clear();
                    Console.WriteLine("Архив разархивирован в {0}\nНажмите любую кнопку...", directory);
                    Console.ReadKey();
                }
            }
            catch (System.IO.IOException e)
            {
                Console.Clear();
                Console.WriteLine("Ошибка разархивирования!  " + e.Message + "\nНажмите любую кнопку...");
                Console.ReadKey();
            }
        }
    }
}
