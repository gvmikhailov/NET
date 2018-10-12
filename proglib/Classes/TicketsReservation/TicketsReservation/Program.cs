using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            BookingOffice bookingOffice = new BookingOffice();
            // Наличие билетов:
            bookingOffice.GetAvailabilityTickets("Praga");
            bookingOffice.GetAvailabilityTickets(BookingOffice.cities[BookingOffice.rnd.Next(BookingOffice.cities.Count)]);
            
            // Запрос цены:
            Console.WriteLine("Цена билета первого класса Moscow - Warsav для взрослого пассажира компании Аэрофлот - {0} руб.", bookingOffice.GetTicketPrice("Warsav", "First", "Аэрофлот", "Adult"));

            // Покупка билетов
            for (int i = 0; i < 10; i++)
            {
                bookingOffice.BuyTicket();
            }
            Console.WriteLine();
            // Бронирование билетов:
            for (int i = 0; i < 10; i++)
            {
                bookingOffice.BookTicket();
                Console.WriteLine();
            }
            Console.WriteLine();
            // Посмотрим, какие куплены билеты:
            Ticket.ShowAllTickets();
            Console.WriteLine();
            // Теперь попробуем вернуть три билета:
            for (int i = 0; i < 3; i++)
            {
                int key = BookingOffice.rnd.Next(1, 20);
                Console.WriteLine("Пытаемся вернуть билет за нумером {0}", key);
                var ticket = bookingOffice.GetTicket(key);
                bookingOffice.RefundTicket(ticket);
            }
            Console.WriteLine();
            // Теперь посмотрим сколько денег в кассе
            Ticket.BuyingTickets();
            Console.WriteLine();
            // И наконец логи операций
            KassaEvents.PrintLogs();
        }
    }
}
