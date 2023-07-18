using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_System_Forrest_Schmeling.Items
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        private int productID;
        private string name;
        private int instock;
        private decimal price;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {

                    price = decimal.Parse(value.Substring(1));

                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int productID, string name, int instock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = instock;
            Price = price.ToString();
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                } else
                {
                    success = false;
                }
            }
            return success;
        }


        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                { return part;

                }
            }
            InhousePart emptyInhousePart = new InhousePart();
            return emptyInhousePart;

        }
    }
}

