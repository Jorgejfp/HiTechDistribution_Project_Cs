using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using HiTechDistribution_Project.VALIDATION;

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
            //this.Hide();
            FrmUserAccount frmUserAccount = new FrmUserAccount();
            frmUserAccount.ShowDialog();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit the application ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            var screenResolution = Screen.PrimaryScreen.Bounds.Size;
            int screenWidth = screenResolution.Width;
            int screenHeight = screenResolution.Height;


            Validator.PositionButton(btnExit, screenWidth, screenHeight);
        }

        private void EmpInfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FrmEmployeeMaintenance frmEmployee = new FrmEmployeeMaintenance();
            frmEmployee.ShowDialog();
        }
    }
}
