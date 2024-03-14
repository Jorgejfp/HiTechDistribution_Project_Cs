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
    }
}
