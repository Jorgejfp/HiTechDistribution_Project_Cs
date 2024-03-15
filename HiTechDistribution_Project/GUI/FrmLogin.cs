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
using HiTechDistribution_Project.BLL;
using HiTechDistribution_Project.DAL;


namespace HiTechDistribution_Project.GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit this Application", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { Application.Exit(); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Trim() == "")
            {
                MessageBox.Show("Please insert a User ID.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
                return;
            }
            int input = 0;

            HiTech db = new HiTech();
            input = Convert.ToInt32(txtUserID.Text.Trim());

            if (!Validator.IsValidID(input))
            {
                MessageBox.Show("Insert a Correct User ID is your Employee ID or You don't have access.", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Clear();
                txtUserID.Focus();
                return;
            }
            db = db.SearchUsers(input);
            if (db != null)
            {
                if (txtPassword.Text == db.Password.ToString() && db.Status == 4)
                {
                    this.Hide();
                    MainForm frmMain = new MainForm();
                    frmMain.ShowDialog();
                }
                else {
                    MessageBox.Show("Insert a Correct Password.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
            }
        }
    }
}
