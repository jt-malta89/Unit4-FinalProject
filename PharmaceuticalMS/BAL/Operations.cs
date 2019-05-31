using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    // Declare the queries and db operations needed for the application
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();

        public int insertVeh(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Vehicles VALUES ('"+info.NumberPlate+ "','" + info.MakeModel + "','" + info.VehicleType + "','" + info.FuelType + "')";
            return db.ExeNonQuery(cmd);
        }

        public int deleteVeh(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Vehicles WHERE NumberPlate='"+info.NumberPlate+"'";
            return db.ExeNonQuery(cmd);
        }

        public int updateVeh(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Vehicles SET NumberPlate='"+info.NumberPlate+"' where NumberPlate='"+info.NumberPlate+"'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable viewvehicles(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Vehicles";
            return db.ExeReader(cmd);
        }

        public DataTable login(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login where Username='"+info.Username+"' and Password='"+info.Password+"'";
            return db.ExeReader(cmd);
        }
    }
}
