using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    internal interface IBookingOffice
    {
        void BuyTicket();
        void RefundTicket(Ticket ticket);
        void BookTicket();
    }
}
