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




    }
}
