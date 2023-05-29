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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Pawnshop.Forms
{
    public partial class SearchForm : Form
    {
        public static string lastText;

        public SearchForm()
        {
            InitializeComponent();
            search_input.Text = lastText;
            var res = MainForm.link.searchFor(lastText);
            lotBindingSource.DataSource = res;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.link.Show();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm.link.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var str = search_input.Text;
            search(str);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)search_output.SelectedItem;
            lastText = search_input.Text;
            this.Hide();
            var EditForm = new EditForm();
            EditForm.from = 1;
            EditForm.Show();
            EditForm.id(selectedItem);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)search_output.SelectedItem;
            MainForm.link.delete(selectedItem);
            var res = MainForm.link.searchFor(lastText);
            lotBindingSource.DataSource = res;
        }
        public void search(string str)
        {
            lastText = str;
            var res = MainForm.link.searchFor(str);
            lotBindingSource.DataSource = res;
            if(res.Count == 0)
            {
                string message = "No lots found.";
                var result = MessageBox.Show(message, "", MessageBoxButtons.OK);
            }
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)search_output.SelectedItem;
            if (selectedItem.date_expire < DateTime.Now)
            {
                MainForm.link.sell(selectedItem);
            }
            else
            {
                string message = "You can not sell this item, expiration date has not yet passed.";
                string caption = "Selling error";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            var res = MainForm.link.searchFor(lastText);
            lotBindingSource.DataSource = res;
        }
    }
}
