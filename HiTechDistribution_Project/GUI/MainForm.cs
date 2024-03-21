using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

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
            FrmUserAccount frmUserAccount = new FrmUserAccount();
            frmUserAccount.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit the application ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); ;
            }
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutUS frmAb = new FrmAboutUS();
            frmAb.ShowDialog();
        }

        private void EmpInfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployeeMaintenance frmEmployee = new FrmEmployeeMaintenance();
            frmEmployee.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchEmployee frmSearchEmployee = new FrmSearchEmployee();
            frmSearchEmployee.ShowDialog();
        }

        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchUserAcc frmSearchUserAcc = new FrmSearchUserAcc();
            frmSearchUserAcc.ShowDialog();
        }
    }
}
