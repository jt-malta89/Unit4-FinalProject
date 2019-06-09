using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime date { get; set; }
        public int PharmacyID { get; set; }
        public int StaffIDCard { get; set; }
    }
}
