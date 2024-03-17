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
    public partial class FrmSearchEmployee : Form
    {
        public FrmSearchEmployee()
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want return to the Main Form", "Exit HiTech List and Search Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                MainForm frmMain = new MainForm();
                frmMain.ShowDialog();
            }
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            HiTech employee = new HiTech();
            List<HiTech> listE = employee.GetEmployeeList();
            listViewEmployee.Items.Clear();
            foreach (HiTech emp in listE)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeID.ToString());
                item.SubItems.Add(emp.EmployeeFName);
                item.SubItems.Add(emp.EmployeeLName);
                item.SubItems.Add(emp.EmployeePhonenumber);
                item.SubItems.Add(emp.EmployeeEmail);
                item.SubItems.Add(emp.EmployeeJobID.ToString());
                item.SubItems.Add(emp.EmployeeStatusID.ToString());
                listViewEmployee.Items.Add(item);
            }

        }

        private void FrmSearchEmployee_Load(object sender, EventArgs e)
        {
            labelLName.Visible = false;
            textBoxInput2.Visible = false;
        }

        private void comboBoxSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBoxSearchOption.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                    CleanText();
                    labelMessage.Text = "Please enter Employee ID.";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    labelLName.Visible = false;
                    textBoxInput2.Visible = false;
                    break;
                case 1:
                    CleanText();
                    labelMessage.Text = "Please enter First Name.";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    labelLName.Visible = false;
                    textBoxInput2.Visible = false;
                    break;
                case 2:
                    CleanText();
                    labelMessage.Text = "Please enter Last Name.";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    labelLName.Visible = false;
                    textBoxInput2.Visible = false;
                    break;
                case 3:
                    CleanText();
                    labelMessage.Text = "Please enter First Name";
                    labelLName.Visible = true;
                    textBoxInput2.Visible = true;
                    labelLName.Text = "Please enter Last Name";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                default:
                    break;
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchOption.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = "";
            HiTech emp = new HiTech();
            switch (comboBoxSearchOption.SelectedIndex)
            {
                case 0:
                    int inputID = Convert.ToInt32(textBoxInput.Text.Trim());
                    if (!Validator.IsValidID(inputID))
                    {
                        MessageBox.Show("Employee Id must be 4-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }
                    emp = emp.SearchEmployee(Convert.ToInt32(inputID));
                    if (emp != null)
                    {
                        txtEmployeeID.Text = emp.EmployeeID.ToString();
                        txtFName.Text = emp.EmployeeFName.ToString();
                        txtLName.Text = emp.EmployeeLName.ToString();
                        txtPhoneNber.Text = emp.EmployeePhonenumber.ToString();
                        txtEmail.Text = emp.EmployeeEmail.ToString();
                        txtJobID.Text = emp.EmployeeJobID.ToString();
                        txtStatusID.Text = emp.EmployeeStatusID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Invalid Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }
                    break;
                case 1: 
                    input = textBoxInput.Text.Trim();
                    List<HiTech> listE = new List<HiTech>();
                    listE = emp.SearchEmployee(input);
                    listViewEmployee.Items.Clear();

                    if (listE.Count == 0)
                    {
                        MessageBox.Show("Employee not found!", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }
                    else
                    {
                        foreach (HiTech empItem in listE)
                        {
                            ListViewItem item = new ListViewItem(empItem.EmployeeID.ToString());
                            item.SubItems.Add(empItem.EmployeeFName);
                            item.SubItems.Add(empItem.EmployeeLName);
                            item.SubItems.Add(empItem.EmployeePhonenumber);
                            item.SubItems.Add(empItem.EmployeeEmail);
                            item.SubItems.Add(empItem.EmployeeJobID.ToString());
                            item.SubItems.Add(empItem.EmployeeStatusID.ToString());
                            listViewEmployee.Items.Add(item);
                        }
                    }
                    break;
                case 2:
                    input = textBoxInput.Text.Trim();
                    List<HiTech> listEFN = new List<HiTech>();
                    listEFN = emp.SearchEmployeeLN(input);
                    listViewEmployee.Items.Clear();

                    if (listEFN.Count == 0)
                    {
                        MessageBox.Show("Employee not found!", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }
                    else
                    {
                        foreach (HiTech empItem in listEFN)
                        {
                            ListViewItem item = new ListViewItem(empItem.EmployeeID.ToString());
                            item.SubItems.Add(empItem.EmployeeFName);
                            item.SubItems.Add(empItem.EmployeeLName);
                            item.SubItems.Add(empItem.EmployeePhonenumber);
                            item.SubItems.Add(empItem.EmployeeEmail);
                            item.SubItems.Add(empItem.EmployeeJobID.ToString());
                            item.SubItems.Add(empItem.EmployeeStatusID.ToString());
                            listViewEmployee.Items.Add(item);
                        }
                    }
                    break;
                case 3:
                    input = textBoxInput.Text.Trim();
                    List<HiTech> listELN = new List<HiTech>();
                    listELN = emp.SearchEmployee(input);
                    listViewEmployee.Items.Clear();

                    if (listELN.Count == 0)
                    {
                        MessageBox.Show("Employee not found!", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }
                    else
                    {
                        foreach (HiTech empItem in listELN)
                        {
                            ListViewItem item = new ListViewItem(empItem.EmployeeID.ToString());
                            item.SubItems.Add(empItem.EmployeeFName);
                            item.SubItems.Add(empItem.EmployeeLName);
                            item.SubItems.Add(empItem.EmployeePhonenumber);
                            item.SubItems.Add(empItem.EmployeeEmail);
                            item.SubItems.Add(empItem.EmployeeJobID.ToString());
                            item.SubItems.Add(empItem.EmployeeStatusID.ToString());
                            listViewEmployee.Items.Add(item);
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
