using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Vehicles
    {
        //Get and set details found in Vehicles table
        public int VehicleID { get; set; }
        public string NumberPlate { get; set; }
        public string MakeModel { get; set; }
        public string VehicleType { get; set; }
        public string FuelType { get; set; }
    }
}
