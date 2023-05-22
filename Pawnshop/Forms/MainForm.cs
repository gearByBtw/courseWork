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
            var res = MessageBox.Show("Do you want to sell this lot?", "", MessageBoxButtons.YesNo);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}