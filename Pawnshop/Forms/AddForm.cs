using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pawnshop.Models;
using Pawnshop.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Pawnshop.Data;

namespace Pawnshop.Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            {
                string item = item_box.Text;
                string itemNoSpaces = item.Replace(" ", string.Empty);
                if ((string.IsNullOrEmpty(item)) || (string.IsNullOrEmpty(itemNoSpaces)))
                {
                    MessageBox.Show("Enter the valid value for the item.");
                    return;
                }

                string client = client_box.Text;
                string clientNoSpaces = client.Replace(" ", string.Empty);
                if ((string.IsNullOrEmpty(client)) || (string.IsNullOrEmpty(clientNoSpaces)))
                {
                    MessageBox.Show("Enter the valid value for the client.");
                    return;
                }


                if ((!double.TryParse(price_box.Text, out double price)) || (price < 0))
                {
                    MessageBox.Show("Enter the valid value for the price.");
                    return;
                }


                if ((!double.TryParse(given_price_box.Text, out double price_given)) || (price_given < 0))
                {
                    MessageBox.Show("Enter the valid value for the given price.");
                    return;
                }


                if ((!int.TryParse(period_box.Text, out int expiration_period)) || (expiration_period < 0))
                {
                    MessageBox.Show("Enter the valid value for the expiration period.");
                    return;
                }

               


                this.Hide();
                MainForm.link.AddNewLot(item, client, price, price_given, expiration_period);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
