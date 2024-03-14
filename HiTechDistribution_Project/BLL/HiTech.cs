using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechDistribution_Project.DAL;


namespace HiTechDistribution_Project.BLL
{
    public class HiTech
    {
        private int userID;
        private string password;
        private int status;

        public int UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public int Status { get => status; set => status = value; }

        public HiTech() 
        {
            userID = 0;
            password = string.Empty;
            status = 0;
        }

        public HiTech(int userID, string password, int status)
        {
            this.UserID = userID;
            this.Password = password;
            this.status = status;
        }
        public HiTech SearchUser(string uId)
        {
            return HiTechDB.SearchUser(uId);

        }
    }
}
