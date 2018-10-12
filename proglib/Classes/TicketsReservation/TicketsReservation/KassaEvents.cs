using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    internal delegate void TicketsStateHandler(object sender, KassaEvents e);

    internal class KassaEvents
    {
        private static readonly List<KassaEvents> _eventsList = new List<KassaEvents>();

        static int counter = 0;

        public int Id { get; set; }
        public string Message { get; private set; }
        public string Events { get; private set; }

        internal KassaEvents(string message, string events)
        {
            Id = ++counter;
            Message = message;
            Events = events;
            _eventsList.Add(this);
        }

        internal static void PrintLogs()
        {
            foreach(KassaEvents m in _eventsList)
            {
                Console.WriteLine($"Запись номер {m.Id}: {m.Message} {m.Events}");
            }
        }
    }
}
