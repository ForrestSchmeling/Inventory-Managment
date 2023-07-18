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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            (new MainForm()).Show(); this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int Minstock;
            int Maxstock;
            int inventoryInstock;
            decimal price;
            try
            {
                Minstock = int.Parse(TextBoxMin.Text);
                Maxstock = int.Parse(TextBoxMax.Text);
                inventoryInstock = int.Parse(TextBoxInventory.Text);
                price = decimal.Parse(TextBoxPrice.Text);
            }
            catch
            {
                MessageBox.Show("ERROR:Inventory,Price, min and max all must be Integer Values");
                return;
            }
            string name = TextBoxName.Text;
            price = decimal.Parse(TextBoxPrice.Text);
            Minstock = int.Parse(TextBoxMin.Text);
            Maxstock = int.Parse(TextBoxMax.Text);
            inventoryInstock = int.Parse(TextBoxInventory.Text);

            if(Minstock > Maxstock)
            {
                MessageBox.Show("ERROR: Max must be greater than min");
                return;
            }
            if(inventoryInstock> Maxstock || inventoryInstock < Minstock)
            {
                MessageBox.Show("ERROR: Inventory must be between min and max values");
                return;
            }
            if (RadioInhouse.Checked)
            {
                InhousePart inPart = new InhousePart((Inventory.AllParts.Count +1), name, inventoryInstock, (int)price, Maxstock, Minstock,int.Parse(TextBoxCompanyID.Text));
                Inventory.addPart(inPart);
            }
            else
            {
                OutsourcedPart outpart = new OutsourcedPart((Inventory.AllParts.Count + 1), name , inventoryInstock, (int)price, Maxstock, Minstock, TextBoxCompanyID.Text);
                Inventory.addPart(outpart);
            }
            Close();
            (new MainForm()).Show();
        }

        private void RadioInhouse_CheckedChanged(object sender, EventArgs e)
        {
            LabelCompanyID.Text = "Machine ID";
        }

        private void RadioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            LabelCompanyID.Text = "Company Name";

        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }
    }
}
