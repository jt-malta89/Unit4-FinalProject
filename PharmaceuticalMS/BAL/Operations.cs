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

        public int insertVeh(Vehicles vehicle)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Vehicles VALUES ('"+ vehicle.NumberPlate+ "','" + vehicle.MakeModel + "','" + vehicle.VehicleType + "','" + vehicle.FuelType + "')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getproduct()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Products";
            return db.ExeReader(cmd);
        }

        public Products getproductByBarcode(int barcode)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Products WHERE Barcode=" + barcode;
            DataTable result = db.ExeReader(cmd);
            DataRowCollection rows = result.Rows;
            if (rows.Count > 0)
            {
                foreach(DataRow rw in rows)
                {
                    Products product = new Products();
                    product.Barcode = (int)rw["Barcode"];
                    product.ItemName = (string)rw["ItemName"];
                    product.ItemDescription = (string)rw["ItemDescription"];
                    product.NotifThre = (int)rw["NotifThre"];
                    product.Price = Convert.ToString(rw["Price"]);
                    product.Quantity = (int)rw["Quantity"];
                    product.StoreID = (int)rw["StoreID"];
                    product.CategoryID = (int)rw["CategoryID"];
                    return product;
                }
            }
            return null;
        }
        
        public int editproduct(Products product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Products SET Barcode='" + product.Barcode + "', ItemName='" + product.ItemName + "', ItemDescription='" + product.ItemDescription + "', NotifThre='" + product.NotifThre + "', Price='" + product.Price + "', Quantity='" + product.Quantity + "', StoreID='" + product.StoreID + "', CategoryID='" + product.CategoryID + "' WHERE Barcode='" + product.Barcode + "';";
            return db.ExeNonQuery(cmd);
        }

        public DataTable SearchStaff(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Staff WHERE IDCard='"+Staff.IDCard+"'";
            return db.ExeReader(cmd);
        }

        public DataTable getStaff()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Staff";
            return db.ExeReader(cmd);
        }

        public int insertStore(Store store)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Stores VALUES ('" + store.Name + "','" + store.Address + "')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getStore()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Stores";
            return db.ExeReader(cmd);
        }

        public int insertProduct(Products product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Products VALUES ('" + product.Barcode + "','" + product.ItemName + "','" + product.ItemDescription + "','" + product.Price + "','" + product.Quantity + "','" + product.NotifThre + "','" + product.StoreID + "','" + product.CategoryID + "')";
            return db.ExeNonQuery(cmd);
        }

        public int deleteStore(Store store)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Stores WHERE Name='" + store.Name + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getItems()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Products";
            return db.ExeReader(cmd);
        }

        public int deleteproduct(Products product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Products WHERE Barcode='" + product.Barcode + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getPharmacy()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Pharmacies";
            return db.ExeReader(cmd);
        }

          public int insertPharmacy(Pharmacy pharmacy)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Pharmacies VALUES ('" + pharmacy.Name + "','" + pharmacy.Address + "')";
            return db.ExeNonQuery(cmd);
        }

        public int insertClient(Client Client)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Clients VALUES ('" + Client.IDCard + "','" + Client.Name + "','" + Client.Surname + "','" + Client.ContactNo + "','" + Client.Address + "')";
            return db.ExeNonQuery(cmd);
        }

        public int insertOrder(Order order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Orders VALUES ('" + order.OrderID + "',@orderDate,'" + order.PharmacyID + "','" + order.StaffIDCard + "')";
            cmd.Parameters.Add(new SqlParameter("orderDate", order.date));
            return db.ExeNonQuery(cmd);         
        }

        public int insertOrderProduct(OrderProduct orderprod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO OrdersProd(OrderID, Barcode, Quantity) VALUES (" + orderprod.orderId + 
                                    "," + orderprod.barcode + "," + orderprod.quantity + ")";
           
            return db.ExeNonQuery(cmd);
        }

        public int deleteVeh(Vehicles vehicle)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Vehicles WHERE NumberPlate='"+ vehicle.NumberPlate+"'";
            return db.ExeNonQuery(cmd);
        }

        public int deletePharmacy(Pharmacy pharmacy)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Pharmacies WHERE Name='" + pharmacy.Name + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getClient()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Clients";
            return db.ExeReader(cmd);
        }

        public DataTable SearchClient(Client Client)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Clients WHERE IDCard='" + Client.IDCard + "'";
            return db.ExeReader(cmd);
        }

        public int editClient(Client Client)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Clients SET IDCard='" + Client.IDCard + "', Name='" + Client.Name + "', Surname='" + Client.Surname + "', ContactNo='" + Client.ContactNo + "',  Address='" + Client.Address + "' WHERE IDCard='" + Client.IDCard + "';";
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

        public int deleteClient(Client Client)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Clients WHERE IDCard='" + Client.IDCard + "'";
            return db.ExeNonQuery(cmd);
        }

        public int deleteStaff(Staff Staff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Staff WHERE IDCard='" + Staff.IDCard + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable getCategory()
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

        public int insertCat(Categories Category)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Category VALUES ('" + Category.Category + "')";
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

        public int deleteCat(Categories Category)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Category WHERE Category='" + Category.Category + "'";
            return db.ExeNonQuery(cmd);
        }

        public DataTable login(Login Login)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Login WHERE Username='"+ Login.Username+"' and Password='"+ Login.Password+"'";
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
