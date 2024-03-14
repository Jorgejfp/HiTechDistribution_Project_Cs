using HiTechDistribution_Project.BLL;
using HiTechDistribution_Project.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                this.Hide();
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
            emp.EmployeeID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            emp.EmployeeFName = txtFname.Text.Trim();
            emp.EmployeeLName = txtLName.Text.Trim();
            emp.EmployeePhonenumber = txtPhoneNber.Text.Trim();
            emp.EmployeeEmail = txtEmail.Text.Trim();
            emp.EmployeeJobID = cmbJobID.SelectedIndex;
            emp.EmployeeStatusID = cmbStatusID.SelectedIndex;
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee data has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
