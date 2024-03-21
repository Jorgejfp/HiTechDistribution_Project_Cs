﻿namespace HiTechDistribution_Project.GUI
{
    partial class FrmSearchUserAcc
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatusID = new System.Windows.Forms.TextBox();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtPhoneNber = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.colEmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJobID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatusID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateUpdated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserStatusID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRolID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserPsw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonListAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(187, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "List User Accounts and search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HiTechDistribution_Project.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(888, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatusID);
            this.groupBox1.Controls.Add(this.txtJobID);
            this.groupBox1.Controls.Add(this.txtPhoneNber);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(39, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 227);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Employee ";
            // 
            // txtStatusID
            // 
            this.txtStatusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusID.Location = new System.Drawing.Point(522, 148);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.ReadOnly = true;
            this.txtStatusID.Size = new System.Drawing.Size(257, 26);
            this.txtStatusID.TabIndex = 75;
            // 
            // txtJobID
            // 
            this.txtJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobID.Location = new System.Drawing.Point(201, 154);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(185, 26);
            this.txtJobID.TabIndex = 74;
            // 
            // txtPhoneNber
            // 
            this.txtPhoneNber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhoneNber.Location = new System.Drawing.Point(203, 117);
            this.txtPhoneNber.Mask = "(999) 000-0000";
            this.txtPhoneNber.Name = "txtPhoneNber";
            this.txtPhoneNber.ReadOnly = true;
            this.txtPhoneNber.Size = new System.Drawing.Size(185, 26);
            this.txtPhoneNber.TabIndex = 73;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(520, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(257, 26);
            this.txtEmail.TabIndex = 69;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(520, 75);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(257, 26);
            this.txtLName.TabIndex = 68;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(201, 78);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(185, 26);
            this.txtFName.TabIndex = 67;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(203, 41);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 26);
            this.txtEmployeeID.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Status ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Job ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Phone Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "First Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "User ID:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(147, 52);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(168, 26);
            this.textBoxInput.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Search By";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(350, 50);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(123, 31);
            this.btnSearchUser.TabIndex = 50;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmployeeId,
            this.colFirstName,
            this.colLastName,
            this.colPhoneNumber,
            this.colEmail,
            this.colJobID,
            this.colStatusID,
            this.colDateCreated,
            this.colDateUpdated,
            this.colUserStatusID,
            this.colRolID,
            this.colUserPsw});
            this.listViewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(35, 350);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.RightToLeftLayout = true;
            this.listViewEmployee.Size = new System.Drawing.Size(1081, 255);
            this.listViewEmployee.TabIndex = 49;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Text = "User ID";
            this.colEmployeeId.Width = 115;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFirstName.Width = 144;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLastName.Width = 128;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DisplayIndex = 5;
            this.colPhoneNumber.Text = "Phone Number";
            // 
            // colEmail
            // 
            this.colEmail.DisplayIndex = 6;
            this.colEmail.Text = "Email";
            // 
            // colJobID
            // 
            this.colJobID.DisplayIndex = 3;
            this.colJobID.Text = "Job ID";
            this.colJobID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colJobID.Width = 127;
            // 
            // colStatusID
            // 
            this.colStatusID.DisplayIndex = 4;
            this.colStatusID.Text = "Status ID";
            this.colStatusID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatusID.Width = 153;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "DateCreated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Text = "Date Updated";
            // 
            // colUserStatusID
            // 
            this.colUserStatusID.Text = "User Status ID";
            // 
            // colRolID
            // 
            this.colRolID.Text = "User Rol ID";
            // 
            // colUserPsw
            // 
            this.colUserPsw.Text = "Password";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(993, 620);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 31);
            this.buttonExit.TabIndex = 48;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonListAll
            // 
            this.buttonListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAll.Location = new System.Drawing.Point(604, 38);
            this.buttonListAll.Name = "buttonListAll";
            this.buttonListAll.Size = new System.Drawing.Size(123, 60);
            this.buttonListAll.TabIndex = 47;
            this.buttonListAll.Text = "&List Users";
            this.buttonListAll.UseVisualStyleBackColor = true;
            this.buttonListAll.Click += new System.EventHandler(this.buttonListAll_Click);
            // 
            // FrmSearchUserAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 663);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.listViewEmployee);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonListAll);
            this.Controls.Add(this.label1);
            this.Name = "FrmSearchUserAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search and List User Account";
            this.Load += new System.EventHandler(this.FrmSearchUserAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.MaskedTextBox txtPhoneNber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader colEmployeeId;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colJobID;
        private System.Windows.Forms.ColumnHeader colStatusID;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonListAll;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateUpdated;
        private System.Windows.Forms.ColumnHeader colUserStatusID;
        private System.Windows.Forms.ColumnHeader colRolID;
        private System.Windows.Forms.ColumnHeader colUserPsw;
    }
}