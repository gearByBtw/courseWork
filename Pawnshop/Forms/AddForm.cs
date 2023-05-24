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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            {
                string item = item_box.Text;
                if (string.IsNullOrEmpty(item))
                {
                    MessageBox.Show("Введіть коректне значення для предмета.");
                    return;
                }

                string client = client_box.Text;
                if (string.IsNullOrEmpty(client))
                {
                    MessageBox.Show("Введіть коректне значення для кліента.");
                    return;
                }


                if (!double.TryParse(price_box.Text, out double price))
                {
                    MessageBox.Show("Введіть коректне значення для ціни.");
                    return;
                }


                if (!double.TryParse(given_price_box.Text, out double price_given))
                {
                    MessageBox.Show("Введіть коректне значення для виданої суми.");
                    return;
                }


                if (!int.TryParse(period_box.Text, out int expiration_period))
                {
                    MessageBox.Show("Введіть коректне значення для терміну зберігання.");
                    return;
                }

               


                this.Hide();
                var MainForm = new MainForm();
                MainForm.Show();
                MainForm.AddNewLot(item, client, price, price_given, expiration_period);
            }

        }

        private void item_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
