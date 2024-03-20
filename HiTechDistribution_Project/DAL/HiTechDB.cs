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
                db.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                db.DateUpdated = Convert.ToDateTime(reader["DateUpdated"]);
                db.Status = Convert.ToInt32(reader["StatusID"]);
                db.RolId = Convert.ToInt32(reader["RolID"]);
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
            cmdSearchUser.CommandText = "SELECT * FROM UserAccounts"+
                "Where UserId = @UserID";
            cmdSearchUser.Parameters.AddWithValue("@UserID", uId);
            SqlDataReader reader = cmdSearchUser.ExecuteReader();
            if (reader.Read())
            {
                db.UserID = Convert.ToInt32(reader["EmployeeID"]);
                db.Password = reader["Password"].ToString().Trim();
                db.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                db.DateUpdated = Convert.ToDateTime(reader["DateUpdated"]);
                db.StatusID = Convert.ToInt32(reader["StatusID"]);
                db.RolId = Convert.ToInt32(reader["RolID"]);
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

        public static void SaveRecordEmployee(HiTech employee)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO Employees (EmployeeID,employeeFName,employeeLName,PhoneNumber,Email,JobID,StatusID) " +
                                    "VALUES(@EmployeeID,@employeeFName,@employeeLName,@PhoneNumber,@Email,@JobID,@StatusID)";
            cmdInsert.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@employeeFName", employee.EmployeeFName);
            cmdInsert.Parameters.AddWithValue("@employeeLName", employee.EmployeeLName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", employee.EmployeePhonenumber);
            cmdInsert.Parameters.AddWithValue("@Email", employee.EmployeeEmail);
            cmdInsert.Parameters.AddWithValue("@JobID", employee.EmployeeJobID);
            cmdInsert.Parameters.AddWithValue("@StatusID", employee.EmployeeStatusID);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static void SaveRecordUser(HiTech user)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO UserAccounts (UserID,Password,DateCreated,DateUpdated,StatusID,RolID) " +
                                    "VALUES(@EmployeeID,@Password,@DateCreated,@DateUpdated,@StatusID,@RolID)";
            cmdInsert.Parameters.AddWithValue("@EmployeeID", user.UserID);
            cmdInsert.Parameters.AddWithValue("@Password", user.Password);
            cmdInsert.Parameters.AddWithValue("@DateCreated", user.DateCreated);
            cmdInsert.Parameters.AddWithValue("@DateUpdated", user.DateUpdated);
            cmdInsert.Parameters.AddWithValue("@RolID", user.RolId);
            cmdInsert.Parameters.AddWithValue("@StatusID", user.StatusID);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        public static List<HiTech> GetAllRecords()
        {
            List<HiTech> listE = new List<HiTech>();
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Employees", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader(); 
            HiTech db;
            while (reader.Read())
            {
                db = new HiTech();
                db.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                db.EmployeeFName = reader["FirstName"].ToString().Trim();
                db.EmployeeLName = reader["LastName"].ToString().Trim();
                db.EmployeePhonenumber = reader["PhoneNumber"].ToString().Trim();
                db.EmployeeEmail = reader["Email"].ToString().Trim();
                db.EmployeeJobID = Convert.ToInt32(reader["JobId"]);
                db.EmployeeStatusID = Convert.ToInt32(reader["StatusId"]);
                listE.Add(db);

            }
            conn.Close();
            return listE;
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

        public static void UpdateRecordEmployee(HiTech empUpdated)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "UPDATE Employees " +
                                    "    set employeeFName=@employeeFName," +
                                    "        employeeLName=@employeeLName," +
                                    "        PhoneNumber=@PhoneNumber," +
                                    "        Email=@Email," +
                                    "        JobID=@JobID," +
                                    "        StatusID=@StatusID" +
                                    " WHERE  EmployeeID=@EmployeeID";
            cmdInsert.Parameters.AddWithValue("@EmployeeID", empUpdated.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@employeeFName", empUpdated.EmployeeFName);
            cmdInsert.Parameters.AddWithValue("@employeeLName", empUpdated.EmployeeLName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", empUpdated.EmployeePhonenumber);
            cmdInsert.Parameters.AddWithValue("@Email", empUpdated.EmployeeEmail);
            cmdInsert.Parameters.AddWithValue("@JobID", empUpdated.EmployeeJobID);
            cmdInsert.Parameters.AddWithValue("@StatusID", empUpdated.EmployeeStatusID); 
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteRecordEmployee(int eId)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE Employees " +
                                     "WHERE EmployeeID=@EmployeeID";
            cmdDelete.Parameters.AddWithValue("@EmployeeID", eId);
            cmdDelete.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateRecordUser(HiTech userUpdated)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "UPDATE UserAccounts " +
                                    "    set Password=@Password," +
                                    "        DateCreated=@DateCreated," +
                                    "        DateUpdated=@DateUpdated," +
                                    "        RolId=@RolId," +
                                    "        StatusID=@StatusID" +
                                    " WHERE  UserID=@EmployeeID";
            cmdInsert.Parameters.AddWithValue("@EmployeeID", userUpdated.UserID);
            cmdInsert.Parameters.AddWithValue("@Password", userUpdated.Password);
            cmdInsert.Parameters.AddWithValue("@DateCreated", userUpdated.DateCreated);
            cmdInsert.Parameters.AddWithValue("@DateUpdated", userUpdated.DateUpdated);
            cmdInsert.Parameters.AddWithValue("@StatusID", userUpdated.StatusID);
            cmdInsert.Parameters.AddWithValue("@RolID", userUpdated.RolId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteRecordUser(int eId)
        {
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE UserAccounts " +
                                     "WHERE UserID=@EmployeeID";
            cmdDelete.Parameters.AddWithValue("@EmployeeID", eId);
            cmdDelete.ExecuteNonQuery();
            conn.Close();
        }
        public static HiTech SearchRecord(int eId)
        {
            HiTech db = new HiTech();

            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                        "WHERE EmployeeID=@EmployeeID";

            cmdSearchById.Parameters.AddWithValue("@EmployeeID", eId);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read()) // if found
            {
                db.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                db.EmployeeFName = reader["FirstName"].ToString().Trim();
                db.EmployeeLName = reader["LastName"].ToString().Trim();
                db.EmployeePhonenumber = reader["PhoneNumber"].ToString().Trim();
                db.EmployeeEmail = reader["Email"].ToString().Trim();
                db.EmployeeJobID = Convert.ToInt32(reader["JobId"]);
                db.EmployeeStatusID = Convert.ToInt32(reader["StatusId"]);
            }

            else  // not found
            {
                db = null;
            }
            conn.Close();
            return db;

        }

        public static List<HiTech> SearchRecord(string input) 
        {
            List<HiTech> listE = new List<HiTech>();
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSearchByName = new SqlCommand();
            cmdSearchByName.Connection = conn;
            cmdSearchByName.CommandText = "SELECT * FROM Employees " +
                                          "WHERE FirstName = @EmployeeFName ";
            cmdSearchByName.Parameters.AddWithValue("@EmployeeFName", input);
            cmdSearchByName.Parameters.AddWithValue("@EmployeeLName", input);
            SqlDataReader reader = cmdSearchByName.ExecuteReader(); 
            HiTech db;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    db = new HiTech();
                    db.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    db.EmployeeFName = reader["FirstName"].ToString().Trim();
                    db.EmployeeLName = reader["LastName"].ToString().Trim();
                    db.EmployeePhonenumber = reader["PhoneNumber"].ToString().Trim();
                    db.EmployeeEmail = reader["Email"].ToString().Trim();
                    db.EmployeeJobID = Convert.ToInt32(reader["JobId"]);
                    db.EmployeeStatusID = Convert.ToInt32(reader["StatusId"]);
                    listE.Add(db);
                }

            }
            conn.Close();
            return listE;

        }
        public static List<HiTech> SearchRecordLN(string input)
        {
            List<HiTech> listE = new List<HiTech>();
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSearchByName = new SqlCommand();
            cmdSearchByName.Connection = conn;
            cmdSearchByName.CommandText = "SELECT * FROM Employees " +
                                          "WHERE LastName = @EmployeeLName ";
            cmdSearchByName.Parameters.AddWithValue("@EmployeeFName", input);
            cmdSearchByName.Parameters.AddWithValue("@EmployeeLName", input);
            SqlDataReader reader = cmdSearchByName.ExecuteReader();
            HiTech db;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    db = new HiTech();
                    db.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    db.EmployeeFName = reader["FirstName"].ToString().Trim();
                    db.EmployeeLName = reader["LastName"].ToString().Trim();
                    db.EmployeePhonenumber = reader["PhoneNumber"].ToString().Trim();
                    db.EmployeeEmail = reader["Email"].ToString().Trim();
                    db.EmployeeJobID = Convert.ToInt32(reader["JobId"]);
                    db.EmployeeStatusID = Convert.ToInt32(reader["StatusId"]);
                    listE.Add(db);
                }

            }
            conn.Close();
            return listE;

        }
        public static List<HiTech> SearchRecord(string input1, string input2) 
        {

            List<HiTech> listE = new List<HiTech>();
            SqlConnection conn = UtilityDB.ConDB();
            SqlCommand cmdSearchByName = new SqlCommand();
            cmdSearchByName.Connection = conn;
            cmdSearchByName.CommandText = "SELECT * FROM Employees " +
                                          "WHERE FirstName = @EmployeeFName " +
                                          " and LastName = @EmployeeLName";
            cmdSearchByName.Parameters.AddWithValue("@employeeFName", input1);
            cmdSearchByName.Parameters.AddWithValue("@employeeLName", input2);
            SqlDataReader reader = cmdSearchByName.ExecuteReader(); 
            HiTech db;
            while (reader.Read())
            {
                db = new HiTech();
                db.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                db.EmployeeFName = reader["FirstName"].ToString().Trim();
                db.EmployeeLName = reader["LastName"].ToString().Trim();
                db.EmployeePhonenumber = reader["PhoneNumber"].ToString().Trim();
                db.EmployeeEmail = reader["Email"].ToString().Trim();
                db.EmployeeJobID = Convert.ToInt32(reader["JobId"]);
                db.EmployeeStatusID = Convert.ToInt32(reader["StatusId"]);
                listE.Add(db);


            }
            conn.Close();
            return listE;

        }


    }
}

