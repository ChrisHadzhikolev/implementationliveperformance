using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public class Participant
    {
        public User user { get; }
        public Ticket ParticipantTicket { get; }
        public ParticipantBalance Balance { get; }
        public int RFID { get; set; }
        public bool CheckedIn { get; set; } = false;


        public Participant(User user, Ticket participantTicket)
        {
            this.user = user;
            ParticipantTicket = participantTicket;
            Balance = new ParticipantBalance();
        }

        public override string ToString()
        {
            return $"{user.RealName} with username: {user.Username} born on {user.DateOfBirth} with email: {user.Email} with Ticket Number: {ParticipantTicket.TicketID} and costs {Balance.Costs.ToString("C2:00", CultureInfo.CurrentCulture)}";
        }
    }
}
