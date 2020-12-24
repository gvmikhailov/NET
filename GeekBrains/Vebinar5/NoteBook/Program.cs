using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoteBook
{
    class Program
    {
        public static List<ToDo> tasks = new List<ToDo>();

        static void Main(string[] args)
        {
            DeserializeFromXml();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        static bool MainMenu()
        {
            Console.Clear();
            PrintTasks();
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("1 - Пометить задачу с номером выполненой");
            Console.WriteLine("2 - Создать задачу");
            Console.WriteLine("3 - Сохранить и выйти из программы");
            Console.Write("\r\nВведите номер пункта: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Введите номер задачи и нажмите Enter:");
                    int number;
                    string enteredNumber = Console.ReadLine();
                    if (Int32.TryParse(enteredNumber, out number) && number < 1 && number > tasks.Count)
                    {
                        if (tasks[number - 1].IsDone ?? false)
                            Console.WriteLine($"Задача с номером {number} уже помечена как сделанная!");
                        else
                        {
                            tasks[number - 1].IsDone = true;
                            Console.WriteLine($"Задача с номером {number} успешно помечена как сделанная!");
                        }                            
                    }
                    else
                    {
                        Console.WriteLine("Неверно задан номер задачи!");
                    }
                    return true;
                case "2":
                    Console.WriteLine($"Создание задачи с номером {tasks.Count + 1}:");
                    Console.WriteLine("Введите описание задачи и нажмите Enter:");                    
                    string title = Console.ReadLine();

                    Console.WriteLine("Если необходимо пометить задачу как сделанную, введите любой символ и нажмите Enter, иначе просто нажмите Enter:");
                    string isDone = Console.ReadLine();

                    ToDo task = new ToDo(title);

                    if (String.IsNullOrEmpty(isDone))
                        task.IsDone = false;
                    else
                        task.IsDone = true;

                    tasks.Add(task);
                    Console.WriteLine("Задача успешно создана");
                    return true;
                case "3":
                    SerializeTasksToXml();
                    return false;
                default:
                    return true;
            }
        }

        static void PrintTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string isDone = tasks[i].IsDone ?? false ? "[*]" : "[ ]";
                Console.WriteLine($"{i}. {tasks[i].Title} {isDone}");
            }
        }

        static void SerializeTasksToXml()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<ToDo>));
            string path = @"D:\Store\Coding\NET\taskz.xml";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, tasks);
            }

            Console.WriteLine("Данные успешно сохранены");
            Console.ReadKey();
        }

        static void DeserializeFromXml()
        {
            string path = @"D:\Store\Coding\NET\taskz.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<ToDo>));
            using (FileStream stream = File.OpenRead(path))
            {
                List<ToDo> tasks = (List<ToDo>)serializer.Deserialize(stream);
            }
        }
    }
}
