using Pawnshop.Models;
using Pawnshop.Forms;
using Pawnshop.Data;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.Metrics;


namespace Pawnshop
{
    public partial class MainForm : Form
    {
        PawnshopList pawnshop;

        public static PawnshopList pawnshopMain;

        public static PawnshopList GetMain()
        {
            if (pawnshopMain == null)
            {
                pawnshopMain = new PawnshopList();
            }
            return pawnshopMain;
        }
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            pawnshop = GetMain();
            mainFormBindingSource.DataSource = pawnshop.Lots;
            bool state = DataAccess.stateLoad();
            if(state)
            {
                DataAccess.Load(pawnshop);
                mainFormBindingSource.ResetBindings(true);
                DataAccess.stateSave(false);
            }
        }
        public void AddNewLot(string item, string client, double price, double price_given, int expiration_period)
        {
            int id = pawnshop.IdCounter++;
            Lot newLot = new Lot(id, item, client, price, price_given, DateTime.Now, DateTime.Now.AddDays(expiration_period));
            pawnshop.Lots.Add(newLot);
            pawnshop.IsDirty = true;
            mainFormBindingSource.ResetBindings(true);
        }
        public void EditLot(int id, string item, string client, double price, double price_given, DateTime date, int expiration_period)
        {
            Lot toBeChanged = pawnshop.Lots.Find(x => x.id == id);
            if (toBeChanged != null)
            {
                toBeChanged.item = item;
                toBeChanged.price = price;
                toBeChanged.client = client;
                toBeChanged.price = price;
                toBeChanged.price_given = price_given;
                toBeChanged.date = date;
                toBeChanged.date_expire = date.AddDays(expiration_period);

                pawnshop.IsDirty = true;
                mainFormBindingSource.ResetBindings(true);
            }
        }

        private void testDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = 10;
            
                for (int i = 1; i < n+1; i++)
                {
                    var newLot = new Lot(pawnshop.IdCounter, "item" + i, "client" + i, 10 + i, 15 + i, DateTime.Now.AddDays(i), DateTime.Now.AddDays(i+3));
                    pawnshop.IdCounter++;
                    pawnshop.Lots.Add(newLot);
                }
            mainFormBindingSource.ResetBindings(true);
            mainFormBindingSource.DataSource = pawnshop.Lots;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            safeExit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddForm = new AddForm();
            AddForm.Show();
        }

        private void ediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            if (selectedItem != null)
            {
                this.Hide();
                var EditForm = new EditForm();
                EditForm.Show();
                EditForm.id(selectedItem);
            }
            else
            {
                string message = "Catched: System.NullReferenceException. You are trying to edit nothing.";
                string caption = "Error";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            safeExit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pawnshop.Lots.Clear();
            pawnshop.IdCounter = 1;
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

        private void ItemList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = ItemList.IndexFromPoint(e.Location); 
                if (index != ListBox.NoMatches)
                {
                    ItemList.SelectedIndex = index; 
                    contextMenuStrip1.Show(ItemList, e.Location); 
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var EditForm = new EditForm();
            EditForm.Show();
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            EditForm.id(selectedItem);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }
        public void delete()
        {
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            if (selectedItem != null)
            {
                string message = "Are you sure you want to delete this element?";
                string caption = "Deleting confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pawnshop.Lots.Remove(selectedItem);
                    pawnshop.IsDirty = true;
                    mainFormBindingSource.ResetBindings(true);
                }
            }
            else
            {
                string message = "Catched: System.NullReferenceException. You are trying to delete nothing.";
                string caption = "Error";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
           
        }
        public void safeExit()
        {
            if (pawnshop.IsDirty)
            {
                string message = "Do you want to save the document?";
                string caption = "Saving confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataAccess.Save(pawnshop);
                }
                else
                {
                    DataAccess.Load(pawnshop);
                }
                DataAccess.stateSave(true);
                Environment.Exit(0);
            }
            else
            {
                DataAccess.stateSave(true);
                Environment.Exit(0);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SearchForm = new SearchForm();
            SearchForm.Show();
        }


    }
}