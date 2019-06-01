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

        public DataTable viewStaff(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Staff";
            return db.ExeReader(cmd);
        }

        public int deleteVeh(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Vehicles WHERE NumberPlate='"+info.NumberPlate+"'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable viewJobTitle(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from JobTitle";
            return db.ExeReader(cmd);
        }

        public DataTable viewCategory(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Category";
            return db.ExeReader(cmd);
        }

        public int insertJobTitle(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO JobTitle VALUES ('" + info.JobTitle + "')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable viewvehicles(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Vehicles";
            return db.ExeReader(cmd);
        }

        public int insertCat(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Category VALUES ('" + info.Category + "')";
            return db.ExeNonQuery(cmd);
        }

        public int deleteJobTitle(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM JobTitle WHERE JobTitle='" + info.JobTitle + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable viewCreateLogin(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login";
            return db.ExeReader(cmd);
        }

        public int insertLog(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Login VALUES ('" + info.Username + "','" + info.Password + "','" + info.Type + "')";
            return db.ExeNonQuery(cmd);
        }

        public int deleteCat(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Category WHERE Category='" + info.Category + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable login(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login where Username='"+info.Username+"' and Password='"+info.Password+"'";
            return db.ExeReader(cmd);
        }

        public int deleteLog(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Login WHERE Username='" + info.Username + "'";
            return db.ExeNonQuery(cmd);
        }
    }
}
