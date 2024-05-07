﻿namespace POS
{
    partial class frmHomepage
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlGroupButton = new System.Windows.Forms.Panel();
            this.btnProdMan = new System.Windows.Forms.Button();
            this.btnEmpMan = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblComparts = new System.Windows.Forms.Label();
            this.lblLB = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlGroupButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.lblDashboard);
            this.pnlMain.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(261, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(993, 830);
            this.pnlMain.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(914, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Black;
            this.lblDashboard.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(3, 4);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(226, 42);
            this.lblDashboard.TabIndex = 8;
            this.lblDashboard.Text = "DASHBOARD";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.pnlGroupButton);
            this.pnlHeader.Controls.Add(this.lblComparts);
            this.pnlHeader.Controls.Add(this.lblLB);
            this.pnlHeader.Location = new System.Drawing.Point(9, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(244, 830);
            this.pnlHeader.TabIndex = 5;
            // 
            // pnlGroupButton
            // 
            this.pnlGroupButton.BackColor = System.Drawing.Color.LightBlue;
            this.pnlGroupButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGroupButton.Controls.Add(this.btnProdMan);
            this.pnlGroupButton.Controls.Add(this.btnEmpMan);
            this.pnlGroupButton.Controls.Add(this.btnHome);
            this.pnlGroupButton.Controls.Add(this.btnLogout);
            this.pnlGroupButton.Controls.Add(this.lblProfile);
            this.pnlGroupButton.Location = new System.Drawing.Point(4, 108);
            this.pnlGroupButton.Name = "pnlGroupButton";
            this.pnlGroupButton.Size = new System.Drawing.Size(230, 712);
            this.pnlGroupButton.TabIndex = 7;
            // 
            // btnProdMan
            // 
            this.btnProdMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProdMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdMan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdMan.ForeColor = System.Drawing.Color.Black;
            this.btnProdMan.Location = new System.Drawing.Point(15, 345);
            this.btnProdMan.Name = "btnProdMan";
            this.btnProdMan.Size = new System.Drawing.Size(196, 54);
            this.btnProdMan.TabIndex = 9;
            this.btnProdMan.Text = "PRODUCT MANAGEMENT";
            this.btnProdMan.UseVisualStyleBackColor = false;
            // 
            // btnEmpMan
            // 
            this.btnEmpMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmpMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpMan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpMan.ForeColor = System.Drawing.Color.Black;
            this.btnEmpMan.Location = new System.Drawing.Point(15, 256);
            this.btnEmpMan.Name = "btnEmpMan";
            this.btnEmpMan.Size = new System.Drawing.Size(196, 54);
            this.btnEmpMan.TabIndex = 8;
            this.btnEmpMan.Text = "EMPLOYEE MANAGEMENT";
            this.btnEmpMan.UseVisualStyleBackColor = false;
            this.btnEmpMan.Click += new System.EventHandler(this.btnEmpMan_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(15, 170);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(196, 54);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(82, 674);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = " LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.Black;
            this.lblProfile.Location = new System.Drawing.Point(78, 11);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(62, 24);
            this.lblProfile.TabIndex = 6;
            this.lblProfile.Text = "Profile";
            // 
            // lblComparts
            // 
            this.lblComparts.AutoSize = true;
            this.lblComparts.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparts.ForeColor = System.Drawing.Color.White;
            this.lblComparts.Location = new System.Drawing.Point(17, 68);
            this.lblComparts.Name = "lblComparts";
            this.lblComparts.Size = new System.Drawing.Size(216, 24);
            this.lblComparts.TabIndex = 7;
            this.lblComparts.Text = "COMPUTER PART STORE";
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Font = new System.Drawing.Font("Arial Black", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLB.Location = new System.Drawing.Point(52, -18);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(147, 101);
            this.lblLB.TabIndex = 7;
            this.lblLB.Text = "LB";
            // 
            // frmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1262, 850);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHomepage";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGroupButton.ResumeLayout(false);
            this.pnlGroupButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlGroupButton;
        private System.Windows.Forms.Button btnProdMan;
        private System.Windows.Forms.Button btnEmpMan;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblComparts;
        private System.Windows.Forms.Label lblLB;
    }
}