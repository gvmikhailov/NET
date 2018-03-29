using System;

namespace TvSetRemoteController
{
    class TvRemoteController
    {
        internal int currentChannel;
        public void SetChannelForward()
        {
            if (currentChannel < 200)
            {
                currentChannel += 1;
                Console.Clear();
                Console.WriteLine("Текущий канал - " + currentChannel);
            }
            else
            {
                currentChannel = 200;
                Console.Clear();
                Console.WriteLine("Текущий канал - " + currentChannel);
            }
        }
        public void SetChannelBackward()
        {
            if (currentChannel > 0)
            {
                currentChannel -= 1;
                Console.Clear();
                Console.WriteLine("Текущий канал - " + currentChannel);
            }
            else
            {
                currentChannel = 0;
                Console.Clear();
                Console.WriteLine("Текущий канал - " + currentChannel);
            }
        }
        public void SetChannelChosen()
        {
            Console.Clear();
            Console.WriteLine("Введите номер канала: ");
            currentChannel = int.Parse(Console.ReadLine());
            if (currentChannel > 200)
            {
                currentChannel = 0;
                Console.Clear();
                Console.WriteLine("Текущий канал установлен в 0 так как вы ввели значение вне диапазона " + currentChannel);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Текущий канал - " + currentChannel);
            }
        }
    }
}
