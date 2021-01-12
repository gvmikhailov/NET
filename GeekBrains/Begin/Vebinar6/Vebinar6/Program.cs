using System;
using System.Diagnostics;

namespace Vebinar6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("1 - Показать все процессы");
            Console.WriteLine("2 - Завершить процесс по id");
            Console.WriteLine("3 - Завершить процесс по имени");
            Console.WriteLine("4 - Выйти из программы");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    ShowAllProcesses();
                    return true;

                case ConsoleKey.D2:
                    KillProcessById();
                    return true;

                case ConsoleKey.D3:
                    KillProcessByName();
                    return true;

                case ConsoleKey.D4:
                    return false;

                default:
                    return true;
            }
        }

        static void ShowAllProcesses()
        {
            Console.Clear();
            Process[] processes = Process.GetProcesses();
            Console.WriteLine();
            Console.WriteLine("ProcessID\tProcessName");
            for (int i = 0; i < processes.Length; i++)
            {
                Console.Write($"{processes[i].Id}\t\t{processes[i].ProcessName}");
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую кнопку.");
            Console.ReadKey();
        }

        static void KillProcessById()
        {
            ShowAllProcesses();
            Console.WriteLine();
            Console.WriteLine("Введите ProcessID и нажмите Enter:");
            string procId = Console.ReadLine();
            int id = 0;
            if (Int32.TryParse(procId, out id) == true && id > 0)
            {
                try
                {
                    Process byId = Process.GetProcessById(id);
                    byId.Kill();
                    Console.WriteLine("Процесс был успешно завершен");
                }
                catch (Exception)
                {
                    Console.WriteLine("Процесса с таким ID не существует!");
                }
            }
            else
            {
                Console.WriteLine("При вводе номера процесса было введено не целое положительное число!");
            }
            Console.WriteLine("Нажмите любую кнопку.");
            Console.ReadKey();
        }

        static void KillProcessByName()
        {
            ShowAllProcesses();
            Console.WriteLine();
            Console.WriteLine("Введите ProcessName и нажмите Enter:");            
            string name = Console.ReadLine();
            Console.WriteLine($"Внимание, программа уничтожит все процессы с имененем {name}!\r\nЕсли вам необходимо завершить конкретный процесс, уничтожьте его по id!\r\nДля возврата в меню нажмите 0, для продолжения любую другую клавишу");
            if (Console.ReadKey().Key == ConsoleKey.D0)
            {
                MainMenu();
            }
            else // Здесь try..catch не нужен, так как ошибки при вводе неправильного имени не возниакет
            {
                Process[] procNames = Process.GetProcesses();
                if (Array.Exists(procNames, element => element.ProcessName == name)) // проверка существования процесса
                { 
                    Process[] byName = Process.GetProcessesByName(name);                    
                    for (int i = 0; i < byName.Length; i++)
                    {
                        byName[i].Kill();
                    }                
                    Console.WriteLine("Процесс был успешно завершен");
                }
                else
                {
                    Console.WriteLine("Процесса с таким PocessName не существует!");
                }
                Console.WriteLine("Нажмите любую кнопку.");
                Console.ReadKey();
            }
        }
    }
}
