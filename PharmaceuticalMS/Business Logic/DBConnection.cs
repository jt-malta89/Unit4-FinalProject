using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Business_Logic
{
    public class DBConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = PharmaceuticalDB; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
        public void insert(VehiclesServices vs)
        {
            con.Open(); 
            SqlCommand cmd = new SqlCommand("insert into vehicles values('" + vs.NumberPlate + "','" + vs.MakeModel + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
