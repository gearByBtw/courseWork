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

namespace Pawnshop.Forms
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
