using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TicketsReservation
{
    class BookingOffice : IBookingOffice
    {
        internal static Random rnd = new Random();

        internal Dictionary<string, int> citiesDistance = new Dictionary<string, int>()
        {
            ["Minsk"] = 716,
            ["Kiev"] = 853,
            ["Riga"] = 917,
            ["Paris"] = 2855,
            ["Amsterdam"] = 2449,
            ["Warsav"] = 1259,
            ["Madrid"] = 4167,
            ["New-York"] = 7506,
            ["Kair"] = 4459
        };

        internal Dictionary<string, int> availability = new Dictionary<string, int>()
        {
            ["Minsk"] = 250,
            ["Kiev"] = 120,
            ["Riga"] = 7,
            ["Paris"] = 0,
            ["Amsterdam"] = 50,
            ["Warsav"] = 100,
            ["Madrid"] = 35,
            ["New-York"] = 10,
            ["Kair"] = 98
        };

        internal static List<string> cities = new List<string>() { "Minsk", "Kiev", "Riga", "Paris", "Amsterdam", "Warsav", "Madrid", "New-York", "Kair" };
        internal static List<string> classes = new List<string>() { "Econom", "First", "Business" };
        internal static List<string> airCompanys = new List<string>() { "Аэрофлот", "S7", "UTair", "Победа", "Red Wings", "Аврора" };
        internal static List<string> peoples = new List<string>() { "Adult", "Child" };

        public void BuyTicket()
        {
            string city = cities[rnd.Next(cities.Count)];
            string clas = classes[rnd.Next(classes.Count)];
            string airCompany = airCompanys[rnd.Next(airCompanys.Count)];
            string people = peoples[rnd.Next(peoples.Count)];
            double price = GetTicketPrice(city, clas, airCompany, people);

            Ticket ticket = new Ticket(city, clas, airCompany, people, price);
            if (availability[city] >= 0)
            {
                ticket.OnBuyingTicket += BuyTicketHandler;
                availability[ticket.City] -= 1;
                ticket.BuyingTicket(new KassaEvents($"Куплен билет номер {ticket.Id} на рейс Москва - {ticket.City}, тип {ticket.People}, авиакомпании {ticket.AirCompany}, Класс - {ticket.Class} за {ticket.Price} руб.", "Билет куплен"));
            }
            else
            {
                ticket.OnBuyingTicket += BuyTicketHandler;
                ticket.BuyingTicket(new KassaEvents($"Отказ в покупке билета номер {ticket.Id} на рейс Москва - {ticket.City}, тип {ticket.People}, авиакомпании {ticket.AirCompany}, Класс - {ticket.Class} за {ticket.Price} руб. из-за отсутствия мест", "Отказ в покупке"));
                RemoveStrings(ticket);
                ticket = null;
            }
        }

        public void RefundTicket(Ticket ticket)
        {            
            if(ticket == null)
            {
                Console.WriteLine("Билета с таким номером не существует!");                
            }
            else
            {
                ticket.OnRefundingTicket += RefundTicketHandler;
                availability[ticket.City] += 1;
                ticket.RefundingTicket(new KassaEvents($"Возвращен билет номер {ticket.Id} на рейс Москва - {ticket.City}, тип {ticket.People}, авиакомпании {ticket.AirCompany}, Класс - {ticket.Class}. Клиенту возвращено 60% стоимости билета - {ticket.Price * 0.6} руб.", "Билет возвращен"));
                RemoveStrings(ticket);
                ticket = null;
            }
        }

        public void BookTicket()
        {
            string city = cities[rnd.Next(cities.Count)];
            string clas = classes[rnd.Next(classes.Count)];
            string airCompany = airCompanys[rnd.Next(airCompanys.Count)];
            string people = peoples[rnd.Next(peoples.Count)];
            double price = GetTicketPrice(city, clas, airCompany, people);

            Ticket ticket = new Ticket(city, clas, airCompany, people, price);
            ticket.OnBuyingTicket += BuyTicketHandler;
            ticket.BuyingTicket(new KassaEvents($"Забронирован билет номер {ticket.Id} на рейс Москва - {ticket.City}, тип {ticket.People}, авиакомпании {ticket.AirCompany}, Класс - {ticket.Class} за {ticket.Price} руб.", "Билет забронирован"));
            int buyOrNot = rnd.Next(0, 2);
            Console.WriteLine("Ждем оплаты...");
            Thread.Sleep(5000);
            if (buyOrNot == 1)
            {
                availability[ticket.City] -= 1;
                Console.WriteLine("Оплата поступила");
                ticket.BuyingTicket(new KassaEvents($"Куплен билет номер {ticket.Id} на рейс Москва - {ticket.City}, тип {ticket.People}, авиакомпании {ticket.AirCompany}, Класс - {ticket.Class} за {ticket.Price} руб.", "Билет куплен"));
            }
            else
            {
                availability[ticket.City] += 1;
                Console.WriteLine("Оплата не поступила");
                ticket.BuyingTicket(new KassaEvents($"Билет номер {ticket.Id} на рейс Москва - {ticket.City}, тип {ticket.People}, авиакомпании {ticket.AirCompany}, Класс - {ticket.Class} за {ticket.Price} руб. не выкуплен", "Бронь снята"));
                RemoveStrings(ticket);
                ticket = null;
            }
        }

        internal double GetTicketPrice(string city, string clas, string airCompany, string human)
        {
            double price = 0;
            int standardKmPrice = 12;
            double coefficientClass = 0;
            double coefficientHum;
            switch (clas)
            {
                case ("First"):
                    {
                        coefficientClass = 2.5;
                        break;
                    }
                case ("Business"):
                    {
                        coefficientClass = 1.8;
                        break;
                    }
                case ("Econom"):
                    {
                        coefficientClass = 1;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Билетов класс {0} не предусмотрены на рейсах до {1}", clas, city);
                        break;
                    }
            }
            coefficientHum = human == "Child" ? 0.6 : 1;
            price = citiesDistance[city] * coefficientClass * coefficientHum * standardKmPrice;
            switch (airCompany)
            {
                case ("Аэрофлот"):
                    {
                        price *= 1;
                        break;

                    }
                case ("S7"):
                    {
                        price *= 0.9;
                        break;
                    }
                case ("UTair"):
                    {
                        price *= 0.85;
                        break;
                    }
                case ("Победа"):
                    {
                        price *= 0.6;
                        break;
                    }
                case ("Red Wings"):
                    {
                        price *= 0.65;
                        break;
                    }
                case ("Аврора"):
                    {
                        price *= 0.7;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Авиакомпания {0} не совершает рейсов из Москвы в {}", airCompany, city);
                        break;
                    }
            }
            price = Math.Round(price, 2);
            return price;
        }

        internal void GetAvailabilityTickets(string city)
        {
            if (availability.ContainsKey(city))
            {
                int availableTickets = availability[city];
                Console.WriteLine("В наличии билетов до {0} - {1}", city, availableTickets);
            }
            else
            {
                Console.WriteLine("В город {0} нет рейсов из Москвы", city);
            }
        }

        internal void RemoveStrings(Ticket ticket)
        {
            int key = 0;
            var stringInDictionary = (from i in Ticket.tickets where i.Key == ticket.Id select i);
            foreach (var m in stringInDictionary)
            {
                key = m.Key; // Поскольку словарь, то только одно значение
            }
            Ticket.tickets.Remove(key);
        }

        internal Ticket GetTicket(int id)
        {
            Ticket ticket = null;
            foreach(var t in Ticket.tickets)
            {
                if (t.Key == id)
                {
                    ticket = t.Value;
                    break;
                }
                else
                {
                    ticket = null;
                }
            }
            return ticket;
        }

        internal static void BuyTicketHandler(object sender, KassaEvents e)
        {
            Console.WriteLine(e.Message + " " + e.Events);
        }

        internal static void RefundTicketHandler(object sender, KassaEvents e)
        {
            Console.WriteLine(e.Message + " " + e.Events);
        }
    }
}
