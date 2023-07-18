using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_System_Forrest_Schmeling.Items
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private int instock;
        private decimal price;
        private int min;
        private int max;
        
        public int PartID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public string Price 
        { get{ return price.ToString("C"); }
            set { if (value.StartsWith("$")){

                    price = decimal.Parse(value.Substring(1));

                } else
                {
                    price = decimal.Parse(value);
                }
            }
        }  
        public int Min {  get; set; }
        public int Max { get; set; }

        
        
    }
}
