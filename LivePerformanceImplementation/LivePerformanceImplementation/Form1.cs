using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformanceImplementation
{
    public partial class Form1 : Form
    {
        Participant p;
        public Form1()
        {
            InitializeComponent();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ticketN = int.Parse(ticketNumTb.Text);
                if (TicketSystem.GetTicketById(ticketN) != null)
                {
                    p = ParticipantSystem.FindParticipantByTicket(TicketSystem.GetTicketById(ticketN));
                    if (p.CheckedIn) 
                    {
                        MessageBox.Show("Participant is already checked in! You cannot check in twice");
                    }
                    else
                    {
                        MessageBox.Show("Participant verified scan the rfid bracelet code");
                        checkInBtn.Enabled = true;
                    }
                    
                }
                else
                {
                    MessageBox.Show("There is no such ticket");
                }
                
            }
            catch (FormatException)
            {

                MessageBox.Show("Ticket number should be numeric!");
            }
        }

        private void checkInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int rfid = int.Parse(rfidTb.Text);
                if (ParticipantSystem.FindParticipantByRFID(rfid) == null)
                {
                    p.RFID = rfid;
                    MessageBox.Show(p.user.RealName + " has been checked out successfully");
                }
                else
                {
                    MessageBox.Show("Already a participant with that rfid code");
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("RFID code should be numeric!");
            }
            checkInBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestaurantForm r = new RestaurantForm();
            r.Show();
            CheckOutForm c = new CheckOutForm();
            c.Show();
            ParticipantSystem.NewParticipant(new User("p", "Zlatan", "g@g.com", new DateTime(2000, 7, 5), "pretendiamencrypted"));
            ParticipantSystem.NewParticipant(new User("p1", "Barry", "gg@g.com", new DateTime(1999, 5, 19), "pretendiamencrypted"));
            ParticipantSystem.NewParticipant(new User("p2", "Iris", "ggg@g.com", new DateTime(1996, 6, 30), "pretendiamencrypted"));
            ParticipantSystem.NewParticipant(new User("p3", "Millie", "gggg@g.com", new DateTime(2004, 7, 12), "pretendiamencrypted"));
            ParticipantSystem.NewParticipant(new User("p4", "Max", "ggggg@g.com", new DateTime(1984, 8, 15), "pretendiamencrypted"));

        }
    }
}
