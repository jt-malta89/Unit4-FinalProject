using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Client
    {
        //Get and set details found in Clients table
        public int IDCard { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ContactNo { get; set; }
        public string Address { get; set; }
    }
}
