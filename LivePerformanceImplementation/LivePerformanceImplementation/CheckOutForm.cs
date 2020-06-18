using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformanceImplementation
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int rfid = int.Parse(rfidTb.Text);
                Participant p = ParticipantSystem.FindParticipantByRFID(rfid);
                if (p != null)
                {
                    if (p.Balance.Costs > 0)
                    {
                        MessageBox.Show($"The participant {p.user.RealName} has to pay {p.Balance.Costs.ToString("C2", CultureInfo.CurrentCulture)}");
                    }
                    p.CheckedIn = false;
                    MessageBox.Show("Participant checked out");
                }
                else
                {
                    MessageBox.Show("No participant with that rfid, try again");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("RFID should be numeric");
            }
        }
    }
}
