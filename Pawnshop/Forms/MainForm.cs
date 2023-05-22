using Pawnshop.Models;
using Pawnshop.Forms;

namespace Pawnshop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var Pawnshop = new PawnshopList();
        }

        private void testDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddForm = new AddForm();
            AddForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var EditForm = new EditForm();
            EditForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}