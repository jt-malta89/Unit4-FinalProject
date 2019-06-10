using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Dbconnection
    {
        //The connect link to SQL Server database
        public SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = PharmaceuticalDB; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
        public SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Perform insert, update and delete function
        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }
        //Retrieve single value from data base or query
        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
        //Perform select query 
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
           
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
    }
}
