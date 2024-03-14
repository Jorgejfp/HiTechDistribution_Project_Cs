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

        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want return to the Main Form", "Exit Employee List and Search Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainForm frmMain = new MainForm();
                frmMain.ShowDialog();
            }
        }
    }
}
