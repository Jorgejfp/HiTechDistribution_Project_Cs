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
        private int jobID;
        private string jobTitle;
        private int statusID;
        private string statusName;
        
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
        public int JobID { get => jobID; set => jobID = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public int StatusID { get => statusID; set => statusID = value; }
        public string StatusName { get => statusName; set => statusName = value; }
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
            jobID = 0;
            jobTitle = string.Empty;
            statusID = 0;
            statusName = string.Empty;
        }

        public HiTech(int userID, 
                      string password, 
                      int status, 
                      int employeeID, 
                      string employeeFName, 
                      string employeeLName, 
                      string employeePhoneNumber, 
                      string employeeEmail, 
                      int employeeJobID, 
                      int employeeStatusID,
                      int jobID,
                      string jobTitle,
                      int statusID,
                      string statusName)
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
            this.jobID = jobID;
            this.jobTitle = jobTitle;
            this.statusID = statusID;
            this.statusName = statusName;
        }
        public HiTech SearchEmployees(int uId)
        {
            return HiTechDB.SearchEmployee(uId);

        }
        public HiTech SearchUsers(int uId)
        {
            return HiTechDB.SearchUser(uId);
        }
        public void SaveEmployee(HiTech emp)
        {
            HiTechDB.SaveRecord(emp);

        }
        public List<HiTech> GetJobsList()
        {
            return HiTechDB.GetAllJobs();
        }

        public List<HiTech> GetStatusList()
        {
            return HiTechDB.GetAllStatus();
        }

        public List<HiTech> GetEmployeeList()
        {
            return HiTechDB.GetAllRecords();
        }

        public HiTech SearchEmployee(int empId)
        {
            return HiTechDB.SearchRecord(empId);

        }

        public List<HiTech> SearchEmployee(string input)
        {
            return HiTechDB.SearchRecord(input);
        }

        public List<HiTech> SearchEmployee(string inputF, string inputL)
        {
            return HiTechDB.SearchRecord(inputF, inputL);
        }

        public bool IsUniqueEmployeeId(int empId) => HiTechDB.IsUniqueId(empId);
        public void UpdateEmployee(HiTech emp) => HiTechDB.UpdateRecord(emp);
        public void DeleteEmployee(int empId) => HiTechDB.DeleteRecord(empId);
    }
}
