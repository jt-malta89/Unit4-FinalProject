using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Products
    {
        public int Barcode { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int NotifThre { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public int StoreID { get; set; }
        public int CategoryID { get; set; }
    }
}
