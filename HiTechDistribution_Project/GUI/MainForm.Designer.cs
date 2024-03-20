namespace HiTechDistribution_Project.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpInfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderClerksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.orderClerksToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpInfToolStripMenuItem,
            this.userInformationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.searchToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.managementToolStripMenuItem.Text = "&Managment";
            // 
            // EmpInfToolStripMenuItem
            // 
            this.EmpInfToolStripMenuItem.Name = "EmpInfToolStripMenuItem";
            this.EmpInfToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.EmpInfToolStripMenuItem.Text = "&Management";
            this.EmpInfToolStripMenuItem.Click += new System.EventHandler(this.EmpInfToolStripMenuItem_Click);
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.userInformationToolStripMenuItem.Text = "&User Account Information";
            this.userInformationToolStripMenuItem.Click += new System.EventHandler(this.userInformationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeInformationToolStripMenuItem1,
            this.userInformationToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // employeeInformationToolStripMenuItem1
            // 
            this.employeeInformationToolStripMenuItem1.Name = "employeeInformationToolStripMenuItem1";
            this.employeeInformationToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // userInformationToolStripMenuItem1
            // 
            this.userInformationToolStripMenuItem1.Name = "userInformationToolStripMenuItem1";
            this.userInformationToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "&Inventory";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "&Sales";
            // 
            // orderClerksToolStripMenuItem
            // 
            this.orderClerksToolStripMenuItem.Name = "orderClerksToolStripMenuItem";
            this.orderClerksToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.orderClerksToolStripMenuItem.Text = "&Order Clerks";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUSToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutUSToolStripMenuItem
            // 
            this.aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            this.aboutUSToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutUSToolStripMenuItem.Text = "&About US";
            this.aboutUSToolStripMenuItem.Click += new System.EventHandler(this.aboutUSToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.LogOutToolStripMenuItem.Text = "&LogOut";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(957, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HiTechDistribution_Project.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1159, 677);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Distribution Inc. - Order Managment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpInfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderClerksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
    }
}