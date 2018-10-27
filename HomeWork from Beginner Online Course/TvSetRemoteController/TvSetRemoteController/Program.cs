using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvSetRemoteController
{
    class Program
    {
        static void Main(string[] args)
        {
            TvRemoteController setChannel = new TvRemoteController();
            Console.WriteLine("Введите начальный номер канала от 0 до 200:");
            setChannel.currentChannel = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Текущий канал - " + setChannel.currentChannel);
            Console.WriteLine("Для переключения каналов вперед нажмите стрелку вверх");
            Console.WriteLine("Для переключения каналов вперед нажмите стрелку вниз");
            Console.WriteLine("Для выбора канала нажмите 0 на NumPad");
            Console.WriteLine("Для выхода из программы нажмите Escape");
            while (true)
            { 
                var selection = Console.ReadKey();
                switch (selection.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            setChannel.SetChannelForward();                           
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            setChannel.SetChannelBackward();
                            break;
                        }
                    case ConsoleKey.NumPad0:
                        {
                            setChannel.SetChannelChosen();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
