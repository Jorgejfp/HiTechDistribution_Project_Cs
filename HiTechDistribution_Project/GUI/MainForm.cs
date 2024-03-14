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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUserAccount frmUserAccount = new FrmUserAccount();
            frmUserAccount.ShowDialog();
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmployeeMaintenance frmEmployee = new FrmEmployeeMaintenance();
            frmEmployee.ShowDialog();
        }

        private void employeeInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSearchEmployee frmSearchEmployee = new FrmSearchEmployee();
            frmSearchEmployee.ShowDialog();
        }

        private void userInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSearchUserAcc frmSearchUserAcc = new FrmSearchUserAcc();
            frmSearchUserAcc.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                this.Hide();
                this.Close(); 
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
            }
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutUS frmAb = new FrmAboutUS();
            frmAb.ShowDialog();
        }
    }
}
