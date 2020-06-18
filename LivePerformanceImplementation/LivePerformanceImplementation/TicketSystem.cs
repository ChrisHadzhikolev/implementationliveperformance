using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public static class TicketSystem
    {
        private static List<Ticket> _tickets = new List<Ticket>(); 
        public static double Revenue { get { return _tickets.Count * 45; } } 

        public static Ticket GetTicketById(int id) 
        {
            foreach (var item in _tickets)
            {
                if (item.TicketID == id) return item;
            }
            return null;
        }

        public static Ticket NewTicket() 
        {
            Ticket ticket = new Ticket();
            _tickets.Add(ticket);
            return ticket;
        }

    }
}
