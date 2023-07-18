using inventory_System_Forrest_Schmeling.Items;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace inventory_System_Forrest_Schmeling
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var PartTable = new BindingSource();
            PartTable.DataSource = inventory_System_Forrest_Schmeling.Items.Inventory.AllParts;
            partTable.DataSource = PartTable;

            var ProductTable = new BindingSource();
            ProductTable.DataSource = inventory_System_Forrest_Schmeling.Items.Inventory.Products;
            productTable.DataSource = ProductTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchButtonPart_Click(object sender, EventArgs e)
        {
            int SearchValue = int.Parse(TextBoxPart.Text);
            if (SearchValue < 1) return;
            Part match = Inventory.lookupPart(int.Parse(TextBoxPart.Text));

            foreach(DataGridViewRow row in partTable.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if(part.PartID == match.PartID)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            (new AddPart()).Show(); this.Hide();
        }


        private void AddProduct_Click(object sender, EventArgs e)
        {
            (new AddProduct()).Show(); this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModifyProduct_Click(object sender, EventArgs e)
        {
            Product SelectedProduct = (Product)productTable.CurrentRow.DataBoundItem;
            new ModifyProduct(SelectedProduct).Show(); this.Hide();
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            if (partTable.CurrentRow.DataBoundItem.GetType() == typeof(inventory_System_Forrest_Schmeling.Items.InhousePart))
            {
                InhousePart inhousepart = (InhousePart)partTable.CurrentRow.DataBoundItem;
                new ModifyPart(inhousepart).Show(); this.Hide();
            }
            else {
                OutsourcedPart outsourcedpart = (OutsourcedPart)partTable.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedpart).Show(); this.Hide();
            }
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmed", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partTable.SelectedRows) {
                    partTable.Rows.RemoveAt(row.Index);
            }
        } 
        else return;
        
       }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmed", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)productTable.CurrentRow.DataBoundItem;
                if(product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot remove product with associated part, Please remove associated parts first");
                    return;
                }
                foreach(DataGridViewRow row in productTable.SelectedRows)
                {
                    productTable.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
        }

        private void SearchButtonProduct_Click(object sender, EventArgs e)
        {
            int SearchValue = int.Parse(TextBoxProduct.Text);
            if(SearchValue < 1) {
                return;
            }
            Product match = Inventory.lookupProduct(int.Parse(TextBoxProduct.Text));

            foreach(DataGridViewRow row in productTable.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if(product.ProductID == match.ProductID)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
    }
}
