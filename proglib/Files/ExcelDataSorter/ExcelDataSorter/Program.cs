using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExcelDataSorter
{
    enum Letters { A = 1, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z }

    class Program
    {
        static void Main(string[] args)
        {
            if(args[0] != "?" || args.Length == 5)
            { 
                try
                { 
                    string fileName = GetFileName(args[0]);
                    int listNumber = GetListNumber(args[1]);
                    int rowNumber = GetRowNumber(args[2]);
                    string range = args[3];
                    string orderBy = args[4];
                    Sorting(fileName, listNumber, rowNumber, range, orderBy);
                    //ExcelDocViewer(fileName);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    PrintHelp();
                    Console.WriteLine("Ошибка: " + ex.Message);                                                            
                }
            }
            else
            {
                Console.Clear();
                PrintHelp();
            }

        }

        static void Sorting(string fileName, int listNumber, int rowNumber, string range, string orderBy)
        {
            OrderBy order;
            Workbook excelFile = new Workbook();
            excelFile.LoadFromFile(fileName);
            Worksheet page = excelFile.Worksheets[listNumber-1];
            if(orderBy == "DESC")
            {
                order = OrderBy.Descending;
            }
            else
            {
                if (orderBy == "ASC")
                {
                    order = OrderBy.Ascending;
                }
                else
                {
                    Console.Clear();
                    PrintHelp();
                    throw new Exception("Неверно указан тип сортировки!");                    
                }
            }
            excelFile.DataSorter.SortColumns.Add(rowNumber-1, order);
            excelFile.DataSorter.Sort(page[range]);
            excelFile.SaveToFile(fileName, ExcelVersion.Version2013);
        }

        static string GetFileName(string fileName)
        {
            if (fileName.Contains("\\"))
            {
                return @fileName;
            }
            else
            { 
            return (Environment.CurrentDirectory.ToString() + fileName);
            }
        }

        static int GetListNumber(string listNumber)
        {
            int list;
            if (Int32.TryParse(listNumber, out list))
            { 
                return list;
            }
            else
            {
                Console.Clear();
                PrintHelp();
                throw new Exception("Вы ввлели не число, указывая номер листа");                
            }
        }

        static int GetRowNumber(string row)
        {
            int rowNumber = 0;
            row = row.ToUpper();
            int rowLength = row.Length; // max = 3, last row = XFD
            List<Letters> letter = new List<Letters>();
            List<string> letters = new List<string>();
            for (int i = 0; i < row.Length; i++)
            {
                letters.Add(row[i].ToString());
                letter.Add((Letters)Enum.Parse(typeof(Letters), letters[i]));
            }
            int compare = String.Compare(row, "XFD");
            if (row.Length == 1)
            {
                rowNumber = (int)letter[0];
            }
            else if(row.Length == 2)
            {
                rowNumber = (int)letter[0] * 26 + (int)letter[1];
            }
            else if (compare > 0)
            {
                Console.Clear();
                PrintHelp();
                throw new Exception("Максимальная колонка - XFD!");
            }
            else if (row.Length == 3)
            {
                rowNumber = (int)letter[0]*676 + (int)letter[1] * 26 + (int)letter[2];
            }
            else
            {
                Console.Clear();
                PrintHelp();
                throw new Exception("Такой колонки не существует!");
            }
            return rowNumber;
        }

        static void ExcelDocViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                Console.Clear();
                PrintHelp();
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        static void PrintHelp()
        {
            Console.WriteLine("\nИСПОЛЬЗОВАНИЕ:\n\tExcelDataSorter.exe  ? | Souce xlsx file | List Number | Row Name | Range | Sorting Type\nЗдесь:\n\tSouce xlsx file - Путь к файлу, который необходимо упорядочить\n\tList Number - Порядковый номер листа\n\tRow Name - Обозначение колонки, по которой необходима сортировка\n\tRange - Диапазон сортировки\n\tSorting Type - Тип сортировки {ASC|DESC} (по возрастанию или убыванию)\n\t? - Вывод данного справочного сообщения\nПРИМЕР:\n1. c:\\Programs\\ExcelDataSorter.exe D:\\Downloads\\12.xlsx 2 M A1:M138 ASC\n2. c:\\Programs\\ExcelDataSorter.exe ?");
            Console.WriteLine();
        }
    }
}
