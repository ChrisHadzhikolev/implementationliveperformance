using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformanceImplementation
{
    public static class ParticipantSystem
    {
        private static List<Participant> _participants= new List<Participant>();
        public static Participant[] Participants { get { return _participants.ToArray(); } }

   
        public static Participant FindParticipantByRFID(int rfid)
        {
            foreach (var item in _participants)
            {
                if (item.RFID == rfid)
                {
                    return item;
                }
            }
            return null;
        }
        public static Participant FindParticipantByTicket(Ticket t) 
        {
            foreach (var item in _participants)
            {
                if (item.ParticipantTicket.TicketID == t.TicketID)
                {
                    return item;
                }
            }
            return null;
        }
        public static Participant FindParticipantById(int id)
        {
            foreach (var item in _participants)
            {
                if (item.user.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Participant FindParticipantByUsername(string username)
        {
            foreach (var item in _participants)
            {
                if (item.user.Username == username)
                {
                    return item;
                }
            }
            return null;
        }
        public static Participant FindParticipantByEmail(string email) 
        {
            foreach (var item in _participants)
            {
                if (item.user.Email == email)
                {
                    return item;
                }
            }
            return null;
        }
        public static bool LoadParticipants() 
        {
            //Here there will be a function from database class which returns array of participants
            return true;
        }
        public static bool NewParticipant(User user) 
        {
            foreach (var item in _participants)
            {
                if (item.user == user) 
                {
                    return false;
                }
            }
            Participant p = new Participant(user, TicketSystem.NewTicket());
            //MessageBox.Show(p.ParticipantTicket.TicketID.ToString());
            _participants.Add(p);
            //MailTicket(user, p.ParticipantTicket);
            
            return true;
        }

  
        // For Website
       /* private static void MailTicket(User user, Ticket ticket) 
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(user.Email);

            mail.From = new MailAddress("eventmail@gmail.com");
            mail.Subject = "Your Ticket";
            string Body = $"Dear Customer,\n We are glad you decided to join our LAN Event. Your Ticket Number is - {ticket.TicketID}. Please, be sure to provide the ticket number, when entering the event.\n\nWe are looking forward to seeing you there. If there is any question, please, be sure to contact us by email - info@lanevent.nl or by phone - 06123456789\nKind Regards,\nLAN Event Team";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            ("username", "password");

            smtp.EnableSsl = true;
            //smtp.Send(mail);
        }*/
    }
}
