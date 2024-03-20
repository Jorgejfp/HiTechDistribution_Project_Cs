using HiTechDistribution_Project.BLL;
using HiTechDistribution_Project.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechDistribution_Project.GUI
{
    public partial class FrmUserAccount : Form
    {
        public FrmUserAccount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want return to the Main Form", "Exit User Maintenance Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                MainForm frmMain = new MainForm();
                frmMain.ShowDialog();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int inputID = 0;
            try
            {
                inputID = Convert.ToInt32(txtEmployeeID.Text.Trim());
                if (!Validator.IsValidID(inputID))
                {
                    MessageBox.Show("Employee Id must be 4-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmployeeID.Clear();
                    txtFname.Clear();
                    txtLName.Clear();
                    txtJobID.Clear();
                    cmbStatusID.Text = "";
                    txtPassword.Clear();
                    txtConfirmationPassword.Clear();
                    txtEmployeeID.Focus();
                    label8.Text = "Date of creation of Password : ";
                    label9.Text = "Last Modification Date of Password : ";

                    return;
                }
            }
            catch 
            {
                MessageBox.Show("Employee Id must be a numeric value.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;
            }
            HiTech emp = new HiTech();
            emp = emp.SearchEmployee(Convert.ToInt32(inputID));
            if (emp != null)
            {
                txtEmployeeID.Text = emp.EmployeeID.ToString();
                txtFname.Text = emp.EmployeeFName.ToString();
                txtLName.Text = emp.EmployeeLName.ToString();
                txtJobID.Text = emp.EmployeeJobID.ToString();
            }
            else
            {
                MessageBox.Show("Employee not found!", "Invalid Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;
            }

            HiTech user = new HiTech();
            user = user.SearchUsers(Convert.ToInt32(inputID));
            if (user != null)
            {
                txtPassword.Text = user.Password.ToString();
                txtConfirmationPassword.Text = user.StatusID.ToString();
                if (Convert.ToInt32(user.StatusID) == 4) 
                { 
                    cmbStatusID.SelectedIndex = 0; 
                }
                else
                {
                    cmbStatusID.SelectedIndex = 1;
                }
                label8.Text = $"Date of creation of Password : {Convert.ToDateTime(user.DateCreated)}";
                label9.Text = $"Last Modification Date of Password : {Convert.ToDateTime(user.DateUpdated)}";
            }
            else
            {
                MessageBox.Show("User not found!, create password, activate Status\n After creating password click on add button", "Invalid User Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStatusID.Focus();
                cmbStatusID.SelectedIndex = 1;
                return;
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
            HiTech userUpdated = new HiTech();

            userUpdated.UserID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            //Colocar try para validar el Status que no haya cambiado
            if (cmbStatusID.SelectedIndex == 1 || cmbStatusID.Text == "")
            {
                MessageBox.Show("User Id need be Active.\n" + "Please change StatusID to ActiveID.", "Status Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string selectedStatus1 = cmbStatusID.SelectedItem.ToString();
                string[] parts1 = selectedStatus1.Split('|');
                if (parts1.Length == 2)
                {
                    userUpdated.StatusID = int.Parse(parts1[0]);
                }
            }
            if (!(txtPassword.Text == "") && (txtPassword.Text.Trim() == txtConfirmationPassword.Text.Trim()))
            {
                userUpdated.Password = txtPassword.Text.Trim();
                userUpdated.DateCreated = DateTime.Now;
                userUpdated.DateUpdated = DateTime.Now;
                userUpdated.RolId = Convert.ToInt32(txtJobID.Text.Trim());
            }
            else
            {
                MessageBox.Show("Erroneous password or confirmation password, both need to be the same.\n" + "Insert Password Again. And It can't be empty", "User Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmationPassword.Clear();
                txtPassword.Focus();
                return;
            }
            
            userUpdated.UpdateEmployee(userUpdated);
            MessageBox.Show("User data has been updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEmployeeID.Clear();
            txtFname.Clear();
            txtLName.Clear();
            cmbStatusID.Text = "";
            txtJobID.Text = "";
            txtPassword.Clear();
            txtConfirmationPassword.Clear();
            txtEmployeeID.Focus();

        }

        private void FrmUserAccount_Load(object sender, EventArgs e)
        {
            HiTech status = new HiTech();
            List<HiTech> listStatus = status.GetStatusList();
            cmbStatusID.Items.Clear();
            foreach (HiTech vstatus in listStatus)
            {
                if (Convert.ToInt32(vstatus.StatusID) >= 4 && Convert.ToInt32(vstatus.StatusID) <= 5)
                {
                    cmbStatusID.Items.Add(vstatus.StatusID.ToString() + "|" + vstatus.StatusName.ToString());
                }
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

            //UserId: Unique
            HiTech user = new HiTech();
            if (!user.IsUniqueEmployeeId(Convert.ToInt32(inputID)))
            {
                MessageBox.Show("User Id must be unique.\n" + "Please update Password of the Employee Id.", "Duplicate Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;

            }
    
            user.UserID = Convert.ToInt32(txtEmployeeID.Text.Trim());
            if (cmbStatusID.SelectedIndex == 1 || cmbStatusID.Text == "")
            {
                MessageBox.Show("User Id need be Active.\n" + "Please change StatusID to ActiveID.", "Status Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                string selectedStatus = cmbStatusID.SelectedItem.ToString();
                string[] parts = selectedStatus.Split('|');
                if (parts.Length == 2)
                {
                    user.StatusID = int.Parse(parts[0]);
                }
            }
            if (!(txtPassword.Text=="") && (txtPassword.Text.Trim() == txtConfirmationPassword.Text.Trim()))
            {
                user.Password = txtPassword.Text.Trim();
                user.DateCreated = DateTime.Now;
                user.DateUpdated = DateTime.Now;
                user.RolId = Convert.ToInt32(txtJobID.Text.Trim());
            }
            else
            {
                MessageBox.Show("Erroneous password or confirmation password, both need to be the same.\n" + "Insert Password Again. And It can't be empty", "User Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmationPassword.Clear();
                txtPassword.Focus();
                return;
            }
            user.SaveUser(user);
            MessageBox.Show("User Password data has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtEmployeeID.Clear();
            txtFname.Clear();
            txtLName.Clear();
            cmbStatusID.Text = "";
            txtJobID.Text = "";
            txtPassword.Clear();
            txtConfirmationPassword.Clear();
            txtEmployeeID.Focus();
        }
    }
}
