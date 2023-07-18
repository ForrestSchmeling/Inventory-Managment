using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_System_Forrest_Schmeling.Items
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }


        public static bool removeProduct(int productID)
        {
            bool success = false;
            foreach (Product product in Products)
            {
                if (productID == product.ProductID)
                {
                    Products.Remove(product);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Removal could not be done!");
                    return success = false;
                }
            }
            return success;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if ((product.ProductID == productID))
                {
                    return product;
                }
            }
            Product emptyProduct = new inventory_System_Forrest_Schmeling.Items.Product();
            return emptyProduct;
        }

        public static void updateProduct(int productID, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == productID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.InStock = updatedProduct.InStock;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(int part)
        {
            Part partToDelete = lookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }
    

        public static Part lookupPart(int  partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = new InhousePart();
            return emptyPart;
        }

        public static void updatePart(int PartID, Part part)
        {
            deletePart(PartID);
            addPart(part);
        }
    }
}
