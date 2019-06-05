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
        //public Informations info = new Informations();
        public Staff Staff = new Staff();

        public int insertVeh(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Vehicles VALUES ('"+ Staff.NumberPlate+ "','" + Staff.MakeModel + "','" + Staff.VehicleType + "','" + Staff.FuelType + "')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable SearchStaff(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Staff where IDCard='"+Staff.IDCard+"'";
            return db.ExeReader(cmd);
        }

        public DataTable viewStaff()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Staff";
            return db.ExeReader(cmd);
        }

        public DataTable getItems()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Items";
            return db.ExeReader(cmd);
        }

        public int insertClient(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Clients VALUES ('" + info.IDCard + "','" + info.Name + "','" + info.Surname + "','" + info.ContactNo + "','" + info.Address + "')";
            return db.ExeNonQuery(cmd);
        }

        public int deleteVeh(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Vehicles WHERE NumberPlate='"+ Staff.NumberPlate+"'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable viewClient(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clients";
            return db.ExeReader(cmd);
        }

        public DataTable SearchClient(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clients where IDCard='" + info.IDCard + "'";
            return db.ExeReader(cmd);
        }

        public int editClient(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Clients SET IDCard='" + info.IDCard + "', Name='" + info.Name + "', Surname='" + info.Surname + "', ContactNo='" + info.ContactNo + "',  Address='" + info.Address + "' WHERE IDCard='" + info.IDCard + "';";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getJobTitle()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM JobTitle";
            return db.ExeReader(cmd);
        }

        public int insertStaff(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Staff VALUES ('" + Staff.IDCard + "','" + Staff.Name + "','" + Staff.Surname + "','" + Staff.ContactNo + "','" + Staff.Salary + "','" + Staff.Address + "','" + Staff.JobTitleID + "','" + Staff.VehicleID + "','" + Staff.LoginID + "')";
            return db.ExeNonQuery(cmd);
        }

        public int deleteClient(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Clients WHERE IDCard='" + info.IDCard + "'";
            return db.ExeNonQuery(cmd);
        }

        public int deleteStaff(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Staff WHERE IDCard='" + Staff.IDCard + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable viewCategory(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Category";
            return db.ExeReader(cmd);
        }

        public int editStaff(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Staff SET IDCard='" + Staff.IDCard + "', Name='" + Staff.Name + "', Surname='" + Staff.Surname + "', ContactNo='" + Staff.ContactNo + "', Salary='" + Staff.Salary + "', Address='" + Staff.Address + "',JobTitleID='" + Staff.JobTitleID + "',VehicleID='" + Staff.VehicleID + "',LoginID='" + Staff.LoginID + "' WHERE IDCard='" + Staff.IDCard + "';";
            return db.ExeNonQuery(cmd);
        }

        public int insertJobTitle(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO JobTitle VALUES ('" + Staff.JobTitle + "')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getvehicles()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Vehicles";
            return db.ExeReader(cmd);
        }

        public int insertCat(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Category VALUES ('" + info.Category + "')";
            return db.ExeNonQuery(cmd);
        }

        public int deleteJobTitle(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM JobTitle WHERE JobTitle='" + Staff.JobTitle + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getLogin()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Login";
            return db.ExeReader(cmd);
        }

        public int insertLog(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Login VALUES ('" + Staff.Username + "','" + Staff.Password + "','" + Staff.Type + "')";
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

        public int deleteLog(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Login WHERE Username='" + Staff.Username + "'";
            return db.ExeNonQuery(cmd);
        }
    }
}
