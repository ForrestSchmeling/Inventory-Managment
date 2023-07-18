using inventory_System_Forrest_Schmeling.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_System_Forrest_Schmeling
{
    public partial class AddProduct : Form
    {
        BindingList <Part> addedParts = new BindingList <Part> ();
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
        public AddProduct()
        {
            InitializeComponent();

            var Toptable = new BindingSource();
            Toptable.DataSource = Inventory.AllParts;
            DataGridViewPart.DataSource = Toptable;

            var BotTable = new BindingSource();
            BotTable.DataSource = addedParts;
            DataGridViewProduct.DataSource = BotTable;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmed", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DataGridViewProduct.SelectedRows)
                {
                    DataGridViewProduct.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            (new MainForm()).Show(); this.Hide();
        }


        private void Add_Click(object sender, EventArgs e)
        {
            Part PartToAdd = (Part)DataGridViewPart.CurrentRow.DataBoundItem;
            addedParts.Add(PartToAdd);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int inventory;
            int min;
            int max;
            decimal price;
            try
            {
                inventory = int.Parse(TextBoxInventory.Text);
                min = int.Parse(TextBoxMin.Text);
                max = int.Parse(TextBoxMax.Text);
                price = decimal.Parse(TextBoxPrice.Text);
            }
            catch
            {
                MessageBox.Show("ERROR: inventory, min, max, and price must be integer values");
                return;
            }
            string name = TextBoxName.Text;
            inventory = int.Parse(TextBoxInventory.Text);
            price = decimal.Parse(TextBoxPrice.Text);
            min = int.Parse(TextBoxMin.Text);
            max = int.Parse(TextBoxMax.Text);
            

            if (min > max)
            {
                MessageBox.Show("ERROR: min cannot be grater than max");
                return;
            }
            if (inventory > max || inventory < min)
            {
                MessageBox.Show("inventory must be between min and max values");
                return;
            }
        Product product = new Product((Inventory.Products.Count +1), name, inventory, (int)price, min, max);
            Inventory.addProduct(product);

            foreach(Part part in addedParts)
            {
                product.addAssociatedPart(part);
            }
            Close();
            MainWindow.productTable.Update();
            MainWindow.productTable.Refresh();
            (new MainForm()).Show();
        }

        private void SearchProduct_Click(object sender, EventArgs e)
        {
            int PartID = int.Parse(TextBoxID.Text);
            Part match = Inventory.lookupPart(PartID);
            foreach(DataGridViewRow row in DataGridViewPart.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

    }
}
