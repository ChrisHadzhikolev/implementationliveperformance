using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public class Ticket
    {
        private static int _idSeeder = 100000000;
        public int TicketID { get; private set; }

        public Ticket()
        {
            TicketID = _idSeeder;
            _idSeeder++;
        }
    }
}
