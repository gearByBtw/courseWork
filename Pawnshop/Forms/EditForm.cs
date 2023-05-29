using Pawnshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Pawnshop.Forms
{
    public partial class EditForm : Form
    {
        public int from;
        public EditForm()
        {
            InitializeComponent();
            if (from != 1)
            {
                from = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string item = item_box.Text;
                string itemNoSpaces = item.Replace(" ", string.Empty);
            if ((string.IsNullOrEmpty(item)) || (string.IsNullOrEmpty(itemNoSpaces)))
                {
                    MessageBox.Show("Invalid item name.");
                    return;
                }

                string client = client_box.Text;
                string clientNoSpaces = client.Replace(" ", string.Empty);
            if ((string.IsNullOrEmpty(client)) || (string.IsNullOrEmpty(clientNoSpaces)))
                {
                    MessageBox.Show("Invalid client name.");
                    return;
                }


                if ((!double.TryParse(price_box.Text, out double price)) || (price < 0))
                {
                    MessageBox.Show("Invalid price.");
                    return;
                }


                if ((!double.TryParse(given_price_box.Text, out double price_given)) || (price_given < 0))
                {
                    MessageBox.Show("Invalid given price.");
                    return;
                }


            string dateString = recieving_box.Text;
            string[] formats = { "dd.MM.yyyy" };
            DateTime date;
            if (!DateTime.TryParseExact(dateString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            { 
                MessageBox.Show("Invalid receiving date.");
                return;
            }


            if ((!int.TryParse(period_box.Text, out int expiration_period)) || (expiration_period < 0))
                {
                    MessageBox.Show("Invalid expiration period.");
                    return;
                }

            int id = int.Parse(id_box.Text);
            string message = "Are you sure you want to edit this element?";
            string caption = "Editting confirmation";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainForm.link.EditLot(id, item, client, price, price_given, date, expiration_period);
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        public void id(Lot changed)
        {
                id_box.Text = changed.id.ToString();
                item_box.Text = changed.item;
                client_box.Text = changed.client;
                price_box.Text = changed.price.ToString();
                given_price_box.Text = changed.price_given.ToString();
                recieving_box.Text = changed.date.ToShortDateString();
                period_box.Text = 3.ToString();  
        }
    }
}
