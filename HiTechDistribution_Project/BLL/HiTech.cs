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
        private int employeeID;
        private string employeeFName;
        private string employeeLName;
        private string employeePhoneNumber;
        private string employeeEmail;
        private int employeeJobID;
        private int employeeStatusID;
        //Users
        public int UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public int Status { get => status; set => status = value; }
        //Employees
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeFName { get => employeeFName; set => employeeFName = value; }
        public string EmployeeLName { get => employeeLName; set => employeeLName = value; }
        public string EmployeePhonenumber { get => employeePhoneNumber; set => employeePhoneNumber = value; }
        public string EmployeeEmail { get => employeeEmail; set => employeeEmail = value; }
        public int EmployeeJobID { get => employeeJobID; set => employeeJobID = value; }
        public int EmployeeStatusID { get => employeeStatusID; set => employeeStatusID = value; }
        public HiTech() 
        {
            userID = 0;
            password = string.Empty;
            status = 0;
            employeeID = 0;
            employeeFName = string.Empty;
            employeeLName = string.Empty;
            employeePhoneNumber = string.Empty;
            employeeEmail = string.Empty;
            employeeJobID= 0;
            employeeStatusID = 0;
        }

        public HiTech(int userID, string password, int status, int employeeID, string employeeFName, string employeeLName, string employeePhoneNumber, string employeeEmail, int employeeJobID, int employeeStatusID)
        {
            this.userID = userID;
            this.password = password;
            this.status = status;
            this.employeeID = employeeID;
            this.employeeFName = employeeFName;
            this.employeeLName = employeeLName;
            this.employeePhoneNumber = employeePhoneNumber;
            this.employeeEmail = employeeEmail;
            this.employeeJobID = employeeJobID;
            this.employeeStatusID = employeeStatusID;
        }

        public HiTech SearchUser(int uId)
        {
            return HiTechDB.SearchUser(uId);

        }
        public void SaveEmployee(HiTech emp)
        {
            HiTechDB.SaveRecord(emp);

        }

        public bool IsUniqueEmployeeId(int empId) => HiTechDB.IsUniqueId(empId);
        //public void UpdateEmployee(Employee emp) => HiTechDB.UpdateRecord(emp);
        //public void DeleteEmployee(int empId) => HiTechDB.DeleteRecord(empId);
    }
}
