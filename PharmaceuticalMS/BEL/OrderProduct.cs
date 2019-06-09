using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderProduct
    {
        public int orderId { get; set; }
        public int barcode { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }

    }
}
