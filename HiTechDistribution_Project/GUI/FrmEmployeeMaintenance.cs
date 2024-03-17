using HiTechDistribution_Project.BLL;
using HiTechDistribution_Project.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HiTechDistribution_Project.GUI
{
    public partial class FrmEmployeeMaintenance : Form
    {
        public FrmEmployeeMaintenance()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want return to the Main Form", "Exit Employee Maintenance Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                MainForm frmMain = new MainForm();
                frmMain.ShowDialog();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int inputID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            if (!Validator.IsValidID(inputID))
            {
                MessageBox.Show("Employee Id must be 4-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;

            }

            //EmpployeeId: Unique
            HiTech emp = new HiTech();
            if (!emp.IsUniqueEmployeeId(Convert.ToInt32(inputID)))
            {
                MessageBox.Show("Employee Id must be unique.\n" + "Please enter another EmployeeId.", "Duplicate EmployeeId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;

            }
            string inputName = txtFname.Text.Trim();

            if (!Validator.IsValidName(inputName))
            {
                MessageBox.Show("Invalid First Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFname.Clear();
                txtFname.Focus();

            }

            inputName = txtLName.Text.Trim();

            if (!Validator.IsValidName(inputName))
            {
                MessageBox.Show("Invalid Last Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLName.Clear();
                txtLName.Focus();

            }

            string inputPhone = txtPhoneNber.Text.Trim();

            if (!Validator.IsValidPhoneNumber(inputPhone))
            {
                MessageBox.Show("Invalid Phone Number, use this format (XXX)XXX-XXXX.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNber.Clear();
                txtPhoneNber.Focus();
            }

            string inputEmail = txtEmail.Text.Trim();
            
            if (!Validator.IsValidEmail(inputEmail))
            {
                MessageBox.Show("User Name is the email address.", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }
            emp.EmployeeID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            emp.EmployeeFName = txtFname.Text.Trim();
            emp.EmployeeLName = txtLName.Text.Trim();
            emp.EmployeePhonenumber = txtPhoneNber.Text.Trim();
            emp.EmployeeEmail = txtEmail.Text.Trim();
            emp.EmployeeJobID = cmbJobID.SelectedIndex+1;
            string selectedStatus = cmbStatusID.SelectedItem.ToString();
            string[] parts = selectedStatus.Split('|');
            if (parts.Length == 2)
            {
                emp.EmployeeStatusID = int.Parse(parts[0]);
            }
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee data has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEmployeeID.Clear();
            txtFname.Clear();
            txtLName.Clear();
            txtPhoneNber.Clear();
            txtEmail.Clear();
            txtEmployeeID.Focus();
        }

    
        private void FrmEmployeeMaintenance_Load(object sender, EventArgs e)
        {

            HiTech jobs= new HiTech();
            List<HiTech> listJobs = jobs.GetJobsList();
            cmbJobID.Items.Clear();
            foreach (HiTech vjob in listJobs)
            {
                cmbJobID.Items.Add(vjob.JobID.ToString() + "|" + vjob.JobTitle.ToString());
            }

            HiTech status = new HiTech();
            List<HiTech> listStatus = status.GetStatusList();
            cmbStatusID.Items.Clear();
            foreach (HiTech vstatus in listStatus)
            {
                if (Convert.ToInt32(vstatus.StatusID) >= 6 && Convert.ToInt32(vstatus.StatusID) <= 8)
                {
                    cmbStatusID.Items.Add(vstatus.StatusID.ToString() + "|" + vstatus.StatusName.ToString());
                }            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int inputID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            if (!Validator.IsValidID(inputID))
            {
                MessageBox.Show("Employee Id must be 4-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtFname.Clear();
                txtLName.Clear();
                txtPhoneNber.Clear();
                txtEmail.Clear();
                txtEmployeeID.Focus();
                return;

            }
            HiTech emp = new HiTech();
            emp = emp.SearchEmployees(Convert.ToInt32(inputID));
            if (emp != null)
            {
                txtEmployeeID.Text = emp.EmployeeID.ToString();
                txtFname.Text = emp.EmployeeFName.ToString();
                txtLName.Text = emp.EmployeeLName.ToString();
                txtPhoneNber.Text = emp.EmployeePhonenumber.ToString();
                txtEmail.Text = emp.EmployeeEmail.ToString();
                cmbJobID.Text = emp.EmployeeJobID.ToString();
                cmbStatusID.Text = emp.EmployeeStatusID.ToString();
            }
            else
            {
                MessageBox.Show("Employee not found!", "Invalid Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;
            }
        }

        private void txtPhoneNber_TextChanged(object sender, EventArgs e)
        {
            string currentText = txtPhoneNber.Text;

            string digitsOnly = Regex.Replace(currentText, @"[^\d]", "");

            if (digitsOnly.Length >= 10)
            {
                string formattedNumber = string.Format("({0}) {1}-{2}",
                    digitsOnly.Substring(0, 3),
                    digitsOnly.Substring(3, 3),
                    digitsOnly.Substring(6));
                txtPhoneNber.Text = formattedNumber;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int inputID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            if (!Validator.IsValidID(inputID))
            {
                MessageBox.Show("Employee Id must be 4-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;

            }

            string inputName = txtFname.Text.Trim();

            if (!Validator.IsValidName(inputName))
            {
                MessageBox.Show("Invalid First Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFname.Clear();
                txtFname.Focus();

            }

            inputName = txtLName.Text.Trim();

            if (!Validator.IsValidName(inputName))
            {
                MessageBox.Show("Invalid Last Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLName.Clear();
                txtLName.Focus();

            }

            string inputPhone = txtPhoneNber.Text.Trim();

            if (!Validator.IsValidPhoneNumber(inputPhone))
            {
                MessageBox.Show("Invalid Phone Number, use this format (XXX)XXX-XXXX.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNber.Clear();
                txtPhoneNber.Focus();
            }

            string inputEmail = txtEmail.Text.Trim();

            if (!Validator.IsValidEmail(inputEmail))
            {
                MessageBox.Show("Invalid email address, Please check again the email.", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }

            HiTech empUpdated = new HiTech();
            empUpdated.EmployeeID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            empUpdated.EmployeeFName = txtFname.Text.Trim();
            empUpdated.EmployeeLName = txtLName.Text.Trim();
            empUpdated.EmployeePhonenumber = txtPhoneNber.Text.Trim();
            empUpdated.EmployeeEmail = txtEmail.Text.Trim();
            string selectedJobs = cmbJobID.SelectedItem.ToString();
            string[] partsj = selectedJobs.Split('|');
            if (partsj.Length == 2|| partsj.Length==1)
            {
                empUpdated.EmployeeJobID = int.Parse(partsj[0]);
            };
            string selectedStatus = cmbStatusID.SelectedItem.ToString();
            string[] parts = selectedStatus.Split('|');
            if (parts.Length == 2)
            {
                empUpdated.EmployeeStatusID = int.Parse(parts[0]);
            }
            empUpdated.UpdateEmployee(empUpdated);
            MessageBox.Show("Employee data has been updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEmployeeID.Clear();
            txtFname.Clear();
            txtLName.Clear();
            txtPhoneNber.Clear();
            txtEmail.Clear();
            txtEmployeeID.Focus();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            HiTech empDeleted = new HiTech();
            var answer = MessageBox.Show("Do you really want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                empDeleted.DeleteEmployee(Convert.ToInt32(txtEmployeeID.Text.Trim()));
                MessageBox.Show("Employee data has been deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtEmployeeID.Clear();
            txtFname.Clear();
            txtLName.Clear();
            txtPhoneNber.Clear();
            txtEmail.Clear();
            txtEmployeeID.Focus(); 
        }
    }
}
