using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechDistribution_Project.BLL;
using System.Data.SqlClient;

namespace HiTechDistribution_Project.DAL
{
    public class HiTechDB
    {
        public static HiTech SearchUser(int uId) 
        {
            HiTech db = new HiTech();
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSearchUser = new SqlCommand();
            cmdSearchUser.Connection = conn;
            cmdSearchUser.CommandText = "Select * from UserAccounts " +
                                        "where UserID = @UserID";
            cmdSearchUser.Parameters.AddWithValue("@UserID", uId);
            SqlDataReader reader = cmdSearchUser.ExecuteReader();
            if (reader.Read())
            {
                db.UserID = Convert.ToInt32(reader["UserID"]);
                db.Password = reader["Password"].ToString().Trim();
                db.Status = Convert.ToInt32(reader["StatusID"]);
            }
            else
            {
                db = null;
            }
            conn.Close();
            return db;
        }
        public static HiTech SearchEmployee(int uId)
        {
            HiTech db = new HiTech();

            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSearchUser = new SqlCommand();
            cmdSearchUser.Connection = conn;
            cmdSearchUser.CommandText = "Select * from Employees " +
                                        "where EmployeeID = @EmployeeID";
            cmdSearchUser.Parameters.AddWithValue("@EmployeeID", uId);
            SqlDataReader reader = cmdSearchUser.ExecuteReader();
            if (reader.Read())
            {
                db.UserID = Convert.ToInt32(reader["UserID"]);
                db.Password = reader["Password"].ToString().Trim();
                db.Status = Convert.ToInt32(reader["StatusID"]);
            }
            else
            {
                db = null;
            }
            conn.Close();
            return db;
        }
        public static bool IsUniqueId(int eId)
        {
            HiTech emp = SearchUser(eId);
            if (emp != null)
            {
                return false;
            }
            return true;
        }

        public static void SaveRecord(HiTech employee)
        {
            // Step 1 : Open DB
            SqlConnection conn = UtilityDB.ConDB();

            //Step 2: Perform INSERT operation
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO Employees (EmployeeId,FirstName,LastName,PhoneNumber,Email,JobID,StatusID) " +
                                    "VALUES(@EmployeeId,@FirstName,@LastName,@PhoneNumber,@Email,@JobID,@StatusID)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", employee.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@FirstName", employee.EmployeeFName);
            cmdInsert.Parameters.AddWithValue("@LastName", employee.EmployeeLName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", employee.EmployeePhonenumber);
            cmdInsert.Parameters.AddWithValue("@Email", employee.EmployeeEmail);
            cmdInsert.Parameters.AddWithValue("@JobID", employee.EmployeeJobID);
            cmdInsert.Parameters.AddWithValue("@StatusID", employee.EmployeeStatusID);
            cmdInsert.ExecuteNonQuery();
            //Step 3 : Close DB
            conn.Close();
        }


    }
}
