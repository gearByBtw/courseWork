using Pawnshop.Models;
using Pawnshop.Forms;
using Pawnshop.Data;
using static System.Reflection.Metadata.BlobBuilder;


namespace Pawnshop
{
    public partial class MainForm : Form
    {
        PawnshopList pawnshop; 
        public MainForm()
        {
            InitializeComponent();
            pawnshop = new PawnshopList();
            mainFormBindingSource.DataSource = pawnshop.Lots;
            DataAccess.Load(pawnshop);
            mainFormBindingSource.ResetBindings(true);
        }

        private void testDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = 101;
            
                for (int i = 1; i < n; i++)
                {
                    var newLot = new Lot(i, "item" + i, "client" + i, 10 + i, 15 + i, DateTime.Now.AddHours(i), DateTime.Now.AddHours(i).AddDays(3));
                    pawnshop.Lots.Add(newLot);
                }
            mainFormBindingSource.ResetBindings(true);
            mainFormBindingSource.DataSource = pawnshop.Lots;
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

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pawnshop.Lots.Clear();
            mainFormBindingSource.ResetBindings(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Save(pawnshop);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(pawnshop);
            mainFormBindingSource.ResetBindings(true);
        }
    }
}