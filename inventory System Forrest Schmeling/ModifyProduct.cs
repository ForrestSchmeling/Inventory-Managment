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
    public partial class ModifyProduct : Form
    {
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
         BindingList<Part> addedParts = new BindingList<Part>();
        public ModifyProduct(Product product)
        {
            InitializeComponent();

            TextBoxID.Text = product.ProductID.ToString();
            ModTextBoxName.Text = product.Name;
            TextBoxInventory.Text = product.InStock.ToString();
            TextBoxPrice.Text = product.Price.Substring(1).ToString();
            TextBoxMax.Text = product.Max.ToString();
            TextBoxMin.Text = product.Min.ToString();

            var TopTable = new BindingSource();
            TopTable.DataSource = Inventory.AllParts;
            DataGridViewPart.DataSource = TopTable;

            foreach(Part part in product.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            DataGridViewProduct.DataSource = botTable;
        }

        

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmed", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part part = (Part)DataGridViewProduct.CurrentRow.DataBoundItem;
                int ID = int.Parse(TextBoxID.Text);

                Product product = Inventory.lookupProduct(ID);
                product.removeAssociatedPart(part.PartID);

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
            Part part = (Part)DataGridViewPart.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(TextBoxID.Text);
            Part match = Inventory.lookupPart(partID);
            foreach (DataGridViewRow row in DataGridViewPart.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if(part.PartID == match.PartID)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int min; 
            int max;
            decimal price;
            int inventory; 
            try
            {
                min = int.Parse(TextBoxMin.Text);
                max = int.Parse(TextBoxMax.Text);
                price = decimal.Parse(TextBoxPrice.Text);
                inventory = int.Parse(TextBoxInventory.Text);
            }
            catch {
                MessageBox.Show("ERROR: Inventory,Price, Min and Max need to be Integer Values");
                return;
            }
            
            int id = int.Parse(TextBoxID.Text);
            string name = ModTextBoxName.Text;
            inventory = int.Parse(TextBoxInventory.Text);
            price = decimal.Parse(TextBoxPrice.Text);
            min = int.Parse(TextBoxMin.Text);
            max = int.Parse(TextBoxMax.Text) ;

            if(min > max)
            {
                MessageBox.Show("ERROR: Min cannot be greater than MAX");
                return;
            }
            if(inventory > max || inventory  < min)
            {
                MessageBox.Show("ERROR: inventory must be between min and max values");
                return;
            }
            Product product = new Product(id, name, inventory, price, min, max);
            foreach(Part part in addedParts)
            {
                product.addAssociatedPart(part);
            }
            Inventory.updateProduct(id, product);
            Close();
            MainWindow.productTable.Update();
            MainWindow.productTable.Refresh();
            (new MainForm()).Show();
        }

        public void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
