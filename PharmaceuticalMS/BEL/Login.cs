using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Login
    {
        //Get and set details found in Login table
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
