using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Staff
    {
        //Get and set details found in Staff table
        public int IDCard { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ContactNo  { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public int JobTitleID { get; set; }
        public string JobTitle { get; set; }
        public int VehicleID { get; set; }
        public string NumberPlate { get; set; }
        public string MakeModel { get; set; }
        public string VehicleType { get; set; }
        public string FuelType { get; set; }
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
