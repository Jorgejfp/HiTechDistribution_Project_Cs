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
                db.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                db.EmployeeFName = reader["FirstName"].ToString().Trim();
                db.EmployeeLName = reader["LastName"].ToString().Trim();
                db.EmployeePhonenumber = reader["PhoneNumber"].ToString().Trim();
                db.EmployeeEmail = reader["Email"].ToString().Trim();
                db.EmployeeJobID = Convert.ToInt32(reader["JobId"]);
                db.EmployeeStatusID = Convert.ToInt32(reader["StatusId"]);
            }
            else
            {
                db = null;
            }
            conn.Close();
            return db;
        }
        public static HiTech SearchUsers(int uId)
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
            SqlConnection conn = UtilityDB.ConDB();
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
            conn.Close();
        }

        public static List<HiTech> GetAllJobs()
        {
            List<HiTech> listJobs = new List<HiTech>();
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSelectJobs = new SqlCommand("SELECT * FROM Jobs", conn);
            SqlDataReader reader = cmdSelectJobs.ExecuteReader(); 
            HiTech ljobs;
            while (reader.Read())
            {
                ljobs = new HiTech();
                ljobs.JobID = Convert.ToInt32(reader["JobId"]);
                ljobs.JobTitle = reader["JobTitle"].ToString();
                listJobs.Add(ljobs);

            }
            conn.Close();
            return listJobs;
        }
        public static List<HiTech> GetAllStatus()
        {
            List<HiTech> listStatus = new List<HiTech>();
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSelectStatus = new SqlCommand("SELECT * FROM Status", conn);
            SqlDataReader reader = cmdSelectStatus.ExecuteReader();
            HiTech lstatus;
            while (reader.Read())
            {
                lstatus = new HiTech();
                lstatus.StatusID = Convert.ToInt32(reader["StatusId"]);
                lstatus.StatusName = reader["State"].ToString();
                listStatus.Add(lstatus);

            }
            conn.Close();
            return listStatus;
        }

        public static void UpdateRecord(HiTech empUpdated)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "UPDATE Employees " +
                                    "    set FirstName=@FirstName," +
                                    "        LastName=@LastName," +
                                    "        PhoneNumber=@PhoneNumber," +
                                    "        Email=@Email," +
                                    "        JobID=@JobID," +
                                    "        StatusID=@StatusID" +
                                    " WHERE  EmployeeID=@EmployeeId";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", empUpdated.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@FirstName", empUpdated.EmployeeFName);
            cmdInsert.Parameters.AddWithValue("@LastName", empUpdated.EmployeeLName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", empUpdated.EmployeePhonenumber);
            cmdInsert.Parameters.AddWithValue("@Email", empUpdated.EmployeeEmail);
            cmdInsert.Parameters.AddWithValue("@JobID", empUpdated.EmployeeJobID);
            cmdInsert.Parameters.AddWithValue("@StatusID", empUpdated.EmployeeStatusID); 
            cmdInsert.ExecuteNonQuery();
            conn.Close();


        }
        public static void DeleteRecord(int eId)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE Employees " +
                                     "WHERE EmployeeId=@EmployeeId";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", eId);
            cmdDelete.ExecuteNonQuery();
            conn.Close();
        }

    }
}

