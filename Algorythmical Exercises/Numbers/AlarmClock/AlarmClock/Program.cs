using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime alarmTime = new DateTime(2018, 10, 28, 11, 27, 00);
            string alarmTimeString = $"{alarmTime:g}";
            while(true)
            {
                string nowString = $"{DateTime.Now:g}";
                if(alarmTimeString == nowString)
                {
                    Console.Clear();
                    Console.WriteLine("Пора вставать!");
                    PlaySound();
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    string substract = alarmTime.Subtract(DateTime.Now).ToString();
                    string leftTime = substract.Remove(substract.Length - 8);
                    Console.WriteLine($"До будильника осталось: {leftTime}");
                    continue;
                }
            }
            
        }

        static void PlaySound()
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri("C:\\Program Files (x86)\\GTA Vice City\\Audio\\bike1_3.wav", UriKind.Absolute));
            player.Play();
            Thread.Sleep(4000);
        }
    }
}
