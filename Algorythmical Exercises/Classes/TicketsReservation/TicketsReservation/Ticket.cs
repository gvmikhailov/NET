using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    internal class Ticket
    {
        internal static Dictionary<int, Ticket> tickets = new Dictionary<int, Ticket>();

        internal event TicketsStateHandler OnBuyingTicket;
        internal event TicketsStateHandler OnRefundingTicket;        

        static int counter = 0;
		
        public int Id { get; set; }
		public string City { get; set; }
        public string Class { get; set; }
        public string AirCompany { get; set; }
        public string People { get; set; }
        public double Price { get; set; }

        internal Ticket(string city, string clas, string airCompany, string people, double price)
        {
            Id = ++counter;
            City = city;
            Class = clas;
            AirCompany = airCompany;
            People = people;
            Price = price;
            tickets.Add(Id, this);
        }

        internal static void BuyingTickets()
        {
            double summ = 0;
            int count = 0;
            foreach(var t in tickets)
            {
                count += 1;
                summ += t.Value.Price;
            }
            Console.WriteLine("Продано билетов - {0} на сумму {1} руб.", count, Math.Round(summ, 2));
        }

        internal static void ShowAllTickets()
        {
            foreach (var t in tickets)
            {
                Console.WriteLine("Билет номер {0}. Рейс Москва - {1}. Класс - {2}. Авиакомпания - {3}. Тип билета - {4}. Цена - {5}", t.Key, t.Value.City, t.Value.Class, t.Value.AirCompany, t.Value.People, Math.Round(t.Value.Price, 2));
            }
        }

        internal void CallEvent(KassaEvents e, TicketsStateHandler handler)
        {
            if (handler != null && e != null)
            {
                handler(this, e);
            }
        }

        internal void BuyingTicket(KassaEvents e)
        {
            CallEvent(e, OnBuyingTicket);
        }

        internal void RefundingTicket(KassaEvents e)
        {
            CallEvent(e, OnRefundingTicket);
        }
    }
}


