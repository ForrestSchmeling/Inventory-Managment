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
    public partial class ModifyPart : Form
    {
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
        public ModifyPart(InhousePart inPart)
        {
            InitializeComponent();
            TextBoxID.Text = inPart.PartID.ToString();
            TextBoxName.Text = inPart.Name;
            TextBoxInventory.Text = inPart.InStock.ToString();
            TextBoxPrice.Text = inPart.Price.Substring(1).ToString();
            TextBoxMax.Text = inPart.Max.ToString();
            TextBoxMin.Text = inPart.Min.ToString();
            TextBoxCompanyMacID.Text = inPart.MachineID.ToString();
        }
        public ModifyPart(OutsourcedPart outPart)
        {
            InitializeComponent();
            TextBoxID.Text = outPart.PartID.ToString();
            TextBoxName.Text = outPart.Name;
            TextBoxInventory.Text = outPart.InStock.ToString();
            TextBoxPrice.Text = outPart.Price.Substring(1).ToString();
            TextBoxMax.Text = outPart.Max.ToString();
            TextBoxMin.Text = outPart.Min.ToString();
            TextBoxCompanyMacID.Text = outPart.CompanyName;
            RadioOutsourced.Checked = true;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            (new MainForm()).Show(); this.Hide();
        }

        private void Part_Load(object sender, EventArgs e)
        {

        }

        private void AddTitle_Click(object sender, EventArgs e)
        {

        }

        private void RadioInhouse_CheckedChanged(object sender, EventArgs e)
        {
            LabelCompanyID.Text = "Machine ID";
        }

        private void RadioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            LabelCompanyID.Text = "Company Name";
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
                MessageBox.Show("ERROR: Inventory,Price, Max and Min must be Integer values");
                return;
            }
            int ID = int.Parse(TextBoxID.Text);
            string Name = TextBoxName.Text;
             price = decimal.Parse(TextBoxPrice.Text);
            Minstock = int.Parse(TextBoxMin.Text);
            Maxstock = int.Parse (TextBoxMax.Text);
            inventoryInstock = int.Parse((TextBoxInventory.Text));

            if(Minstock > Maxstock)
            {
                MessageBox.Show("ERROR: MAx must be greater than Min");
                return;
            }
            if(inventoryInstock > Maxstock || inventoryInstock < Minstock) {
                MessageBox.Show("ERROR: Inventory's values must be between Max and Min");
                return;
            }
            if(RadioInhouse.Checked)
            {
                InhousePart inhousePart = new InhousePart(ID, Name, inventoryInstock, price, Minstock, Maxstock, int.Parse(TextBoxCompanyMacID.Text));
                Inventory.updatePart(ID, inhousePart);
                RadioInhouse.Checked = true;
            }
            else
            {
                OutsourcedPart outsourcedPart = new OutsourcedPart (ID, Name, inventoryInstock, price, Minstock, Maxstock, TextBoxCompanyMacID.Text);
                Inventory.updatePart(ID, outsourcedPart);
                RadioOutsourced.Checked = true;
            }
            Close();
            MainWindow.partTable.Update();
            MainWindow.partTable.Refresh();
            (new MainForm()).Show();
        }
    }
}
