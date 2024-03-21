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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HiTechDistribution_Project.GUI
{
    public partial class FrmSearchUserAcc : Form
    {
        public FrmSearchUserAcc()
        {
            InitializeComponent();
        }
        private void CleanText()
        {
            txtEmployeeID.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtPhoneNber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtJobID.Text = string.Empty;
            txtStatusID.Text = string.Empty;
        }
        
        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {

        }

        private void FrmSearchUserAcc_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            HiTech user = new HiTech();
            List<HiTech> listE = user.GetUserList();
            listViewEmployee.Items.Clear();
            foreach (HiTech usr in listE)
            {
                ListViewItem item = new ListViewItem(usr.UserID.ToString());
                item.SubItems.Add(usr.EmployeeFName);
                item.SubItems.Add(usr.EmployeeLName);
                item.SubItems.Add(usr.EmployeePhonenumber);
                item.SubItems.Add(usr.EmployeeEmail);
                item.SubItems.Add(usr.EmployeeJobID.ToString());
                item.SubItems.Add(usr.EmployeeStatusID.ToString());
                item.SubItems.Add(usr.DateCreated.ToString());
                item.SubItems.Add(usr.DateUpdated.ToString());
                item.SubItems.Add(usr.StatusID.ToString());
                item.SubItems.Add(usr.RolId.ToString());
                item.SubItems.Add(usr.Password);
                listViewEmployee.Items.Add(item);
            }
            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want return to the Main Form", "Exit HiTech List and Search Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                MainForm frmMain = new MainForm();
                frmMain.ShowDialog();
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            
            string input = "";
            HiTech usr = new HiTech();
            int inputID = Convert.ToInt32(textBoxInput.Text.Trim());
                    if (!Validator.IsValidID(inputID))
                    {
                        MessageBox.Show("Employee Id must be 4-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }
                    usr = usr.SearchUsers(Convert.ToInt32(inputID));
                    if (usr != null)
                    {
                        txtEmployeeID.Text = usr.UserID.ToString();
                        txtFName.Text = usr.EmployeeFName.ToString();
                        txtLName.Text = usr.EmployeeLName.ToString();
                        txtPhoneNber.Text = usr.EmployeePhonenumber.ToString();
                        txtEmail.Text = usr.EmployeeEmail.ToString();
                        txtJobID.Text = usr.EmployeeJobID.ToString();
                        txtStatusID.Text = usr.EmployeeStatusID.ToString();
                        MessageBox.Show("Employee does meet User Account!", "Valid User Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            else
                    {
                        MessageBox.Show("Employee does not meet user account, check if you must have user account.\n If is positive enter user maintenance to create your User Account!", "Invalid User Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }
             
        }

    }
}
