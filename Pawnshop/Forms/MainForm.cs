using Pawnshop.Models;
using Pawnshop.Forms;
using Pawnshop.Data;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Pawnshop
{
    public partial class MainForm : Form
    {
        PawnshopList pawnshop;

        public static MainForm MainLink;

        public static PawnshopList lastList;

        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            pawnshop = new PawnshopList();
            MainLink = this;
            DataAccess.Load(pawnshop);
            mainFormBindingSource.DataSource = pawnshop.Lots;
        }
        public void AddNewLot(string item, string client, double price, double price_given, int expiration_period)
        {
            int id = pawnshop.IdCounter++;
            Lot newLot = new Lot(id, item, client, price, price_given, DateTime.Now, DateTime.Now.AddDays(expiration_period));
            pawnshop.Lots.Add(newLot);
            pawnshop.IsDirty = true;
            update();
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
                update();
            }
        }
        public List<Lot> searchFor(string searchValue)
        {
            var searchResults = new List<Lot>();

            int searchInt;
            bool isInt = int.TryParse(searchValue, out searchInt);

            double searchDouble;
            bool isDouble = double.TryParse(searchValue, out searchDouble);

            DateTime searchDate;
            bool isDate = DateTime.TryParseExact(searchValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out searchDate);

            searchResults = pawnshop.Lots.Where(obj =>
           (isInt && obj.id == searchInt) ||
           obj.item == searchValue ||
           obj.client == searchValue ||
           (isDouble && (obj.price == searchDouble || obj.price_given == searchDouble)) ||
           (isDate && (obj.date.ToShortDateString() == searchValue || obj.date_expire.ToShortDateString() == searchValue))
           ).Distinct().ToList();

            searchResults.AddRange(pawnshop.Lots.Where(obj =>
            obj.item.Contains(searchValue) ||
            obj.client.Contains(searchValue) 
            ).Distinct().ToList());

            HashSet<Lot> uniqueSet = new HashSet<Lot>(searchResults);
            List<Lot> uniqueList = new List<Lot>(uniqueSet);
            return uniqueList;
        }

        public void delete(Lot selectedItem)
        {
            if (selectedItem != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete this element?", "Deleting confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pawnshop.Lots.Remove(selectedItem);
                    pawnshop.IsDirty = true;
                    update();
                }
            }
            else
            {
                var result = MessageBox.Show("Catched: System.NullReferenceException. You are trying to delete nothing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void sell(Lot selectedItem)
        {
            if (selectedItem != null)
            {
                var result = MessageBox.Show("Are you sure you want to sell this element?", "Selling confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pawnshop.Lots.Remove(selectedItem);
                    pawnshop.IsDirty = true;
                    update();
                }
            }
            else
            {
                var result = MessageBox.Show("Catched: System.NullReferenceException. You are trying to sell nothing.", "Error", MessageBoxButtons.OK);
            }
        }

        public void update(bool IsSearchButton = false)
        {
            var str = search_input.Text;
            if (str == "")
            {
                mainFormBindingSource.ResetBindings(true);
                mainFormBindingSource.DataSource = pawnshop.Lots;
            }
            else
            {
                var res = searchFor(str);
                mainFormBindingSource.DataSource = res;
                if ((res.Count == 0) && (IsSearchButton))
                {
                    var result = MessageBox.Show("No lots found.", "", MessageBoxButtons.OK);
                }
            }
        }
        public void testData(int n)
        {
            pawnshop.IsDirty = true;
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 2 == 0)
                {
                    var newLot = new Lot(pawnshop.IdCounter, "item" + i, "client" + i, 10 + i, 15 + i, DateTime.Now.AddDays(i), DateTime.Now.AddDays(i + 3));
                    pawnshop.IdCounter++;
                    pawnshop.Lots.Add(newLot);
                }
                else
                {
                    var newLot = new Lot(pawnshop.IdCounter, "item" + i, "client" + i, 10 + i, 15 + i, DateTime.Now.AddDays(-365 + i), DateTime.Now.AddDays(-365 + i + 3));
                    pawnshop.IdCounter++;
                    pawnshop.Lots.Add(newLot);
                }
            }
            update();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddForm = new AddForm();
            AddForm.ShowDialog();
        }

        private void ediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            if (selectedItem != null)
            {
                var EditForm = new EditForm();
                EditForm.id(selectedItem);
                EditForm.ShowDialog(); 
            }
            else
            {
                var result = MessageBox.Show("Catched: System.NullReferenceException. You are trying to edit nothing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pawnshop.IsDirty)
            {
                var result = MessageBox.Show("Do you want to save the document before closing?", "Saving confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pawnshop.IsDirty = false;
                    DataAccess.Save(pawnshop);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                var result = MessageBox.Show("Do you want to close the program?", "Closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pawnshop.Lots.Clear();
            pawnshop.IdCounter = 1;
            pawnshop.IsDirty = true;
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
            var EditForm = new EditForm();
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            EditForm.id(selectedItem);
            EditForm.ShowDialog();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            delete(selectedItem);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            delete(selectedItem);
        }
        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            if(selectedItem.date_expire < DateTime.Now)
            {
                sell(selectedItem);
            }
            else
            {
                var res = MessageBox.Show("You can not sell this item, expiration date has not yet passed.", "Selling error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lot selectedItem = (Lot)ItemList.SelectedItem;
            if (selectedItem.date_expire < DateTime.Now)
            {
                sell(selectedItem);
            }
            else
            {
                var res = MessageBox.Show("You can not sell this item, expiration date has not yet passed.", "Selling error", MessageBoxButtons.OK);
            }
        }
        private void search_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                update(true);
                e.Handled = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            update(true);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            testData(10);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            testData(100);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            testData(1000);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            testData(10000);
        }
    }
}