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
    public partial class RestaurantForm : Form
    {
        Restaurant r;
        public RestaurantForm()
        {
            InitializeComponent();
            r = new Restaurant();
        }

        private void RestaurantForm_Load(object sender, EventArgs e)
        {
            foreach (var item in r.Items)
            {
                if (item.Key is Food) 
                { 
                    comboBox1.Items.Add(item.Key.ToString());
                }
                else
                {
                    comboBox2.Items.Add(item.Key.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                r.AddItemToCart(r.GetItemByName(comboBox1.SelectedItem.ToString()), (int)fNum.Value);
                updateLb();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("error occured, try again");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                r.AddItemToCart(r.GetItemByName(comboBox2.SelectedItem.ToString()), (int)dNum.Value);              
                updateLb();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("error occured, try again");
            }
        }
        private void updateLb() 
        {
            listBox1.Items.Clear();
            foreach (var item in r.Cart) 
            {
                listBox1.Items.Add(item.Value + " x " + item.Key.ToString());
            }
        }

        private void foodRBtn_Click(object sender, EventArgs e)
        {
            try
            {
                r.RemoveItemFromCart(r.GetItemByName(comboBox1.SelectedItem.ToString()), (int)fNum.Value);                
                updateLb();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("error occured, try again");
            }
        }

        private void drinkRBtn_Click(object sender, EventArgs e)
        {
            try
            {
                r.RemoveItemFromCart(r.GetItemByName(comboBox2.SelectedItem.ToString()), (int)dNum.Value);                
                updateLb();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("error occured, try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rfid = int.Parse(rfidTb.Text);
                Participant p = ParticipantSystem.FindParticipantByRFID(rfid);
                if (p != null)
                {
                    r.Purchase(p);
                    MessageBox.Show("Order finalized. Say Have a nice day to the client :)");
                }
                else
                {
                    MessageBox.Show("No participant with that RFID");
                }

            }
            catch (ArgumentException ae) 
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("error occured, try again");
            }
            
        }
    }
}
