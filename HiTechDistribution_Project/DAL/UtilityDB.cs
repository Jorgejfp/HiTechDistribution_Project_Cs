using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HiTechDistribution_Project.DAL
{
    internal class UtilityDB
    {
        public static SqlConnection ConDB()
        {
            SqlConnection connectionDB = new SqlConnection();
            connectionDB.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            connectionDB.Open();
            return connectionDB;

        }
    }
}
