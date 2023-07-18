using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_System_Forrest_Schmeling.Items
{
    public class InhousePart : Part
    {
        private int machineID;
        public int MachineID { get; set; }
        public InhousePart() { }
        public InhousePart(int partID, string name, int instock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public InhousePart(int partID, string name, int instock, decimal price, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
