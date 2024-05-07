namespace POS
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.btnClose = new System.Windows.Forms.Button();
            this.pboxPassworShow = new System.Windows.Forms.PictureBox();
            this.pboxHidePassword = new System.Windows.Forms.PictureBox();
            this.lblEmptyPass = new System.Windows.Forms.Label();
            this.lblEmptyUser = new System.Windows.Forms.Label();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.picboxDesignTop = new System.Windows.Forms.PictureBox();
            this.picboxDesignbottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassworShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignbottom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(365, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pboxPassworShow
            // 
            this.pboxPassworShow.BackColor = System.Drawing.Color.White;
            this.pboxPassworShow.Image = ((System.Drawing.Image)(resources.GetObject("pboxPassworShow.Image")));
            this.pboxPassworShow.Location = new System.Drawing.Point(350, 333);
            this.pboxPassworShow.Name = "pboxPassworShow";
            this.pboxPassworShow.Size = new System.Drawing.Size(25, 21);
            this.pboxPassworShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPassworShow.TabIndex = 20;
            this.pboxPassworShow.TabStop = false;
            // 
            // pboxHidePassword
            // 
            this.pboxHidePassword.BackColor = System.Drawing.Color.White;
            this.pboxHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("pboxHidePassword.Image")));
            this.pboxHidePassword.Location = new System.Drawing.Point(350, 334);
            this.pboxHidePassword.Name = "pboxHidePassword";
            this.pboxHidePassword.Size = new System.Drawing.Size(25, 21);
            this.pboxHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHidePassword.TabIndex = 21;
            this.pboxHidePassword.TabStop = false;
            // 
            // lblEmptyPass
            // 
            this.lblEmptyPass.AutoSize = true;
            this.lblEmptyPass.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyPass.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyPass.Location = new System.Drawing.Point(159, 362);
            this.lblEmptyPass.Name = "lblEmptyPass";
            this.lblEmptyPass.Size = new System.Drawing.Size(125, 15);
            this.lblEmptyPass.TabIndex = 17;
            this.lblEmptyPass.Text = "Password is required!";
            // 
            // lblEmptyUser
            // 
            this.lblEmptyUser.AutoSize = true;
            this.lblEmptyUser.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyUser.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyUser.Location = new System.Drawing.Point(155, 296);
            this.lblEmptyUser.Name = "lblEmptyUser";
            this.lblEmptyUser.Size = new System.Drawing.Size(129, 15);
            this.lblEmptyUser.TabIndex = 18;
            this.lblEmptyUser.Text = "Username is required!";
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblIndicator.Location = new System.Drawing.Point(109, 246);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(215, 15);
            this.lblIndicator.TabIndex = 19;
            this.lblIndicator.Text = "Username and password don\'t match!";
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(146, 69);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(148, 144);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 16;
            this.picboxLogo.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Aqua;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(146, 419);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(148, 44);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtboxPassword.Location = new System.Drawing.Point(56, 330);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '•';
            this.txtboxPassword.Size = new System.Drawing.Size(323, 29);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.Text = "Password";
            this.txtboxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxUsername_KeyPress);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtboxUsername.Location = new System.Drawing.Point(56, 264);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(323, 29);
            this.txtboxUsername.TabIndex = 1;
            this.txtboxUsername.Text = "Username";
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            this.txtboxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxUsername_KeyPress);
            // 
            // picboxDesignTop
            // 
            this.picboxDesignTop.BackColor = System.Drawing.Color.Transparent;
            this.picboxDesignTop.Image = ((System.Drawing.Image)(resources.GetObject("picboxDesignTop.Image")));
            this.picboxDesignTop.Location = new System.Drawing.Point(-127, -261);
            this.picboxDesignTop.Name = "picboxDesignTop";
            this.picboxDesignTop.Size = new System.Drawing.Size(553, 408);
            this.picboxDesignTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxDesignTop.TabIndex = 14;
            this.picboxDesignTop.TabStop = false;
            // 
            // picboxDesignbottom
            // 
            this.picboxDesignbottom.BackColor = System.Drawing.Color.Transparent;
            this.picboxDesignbottom.Image = ((System.Drawing.Image)(resources.GetObject("picboxDesignbottom.Image")));
            this.picboxDesignbottom.Location = new System.Drawing.Point(-24, 334);
            this.picboxDesignbottom.Name = "picboxDesignbottom";
            this.picboxDesignbottom.Size = new System.Drawing.Size(553, 408);
            this.picboxDesignbottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxDesignbottom.TabIndex = 15;
            this.picboxDesignbottom.TabStop = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 617);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pboxPassworShow);
            this.Controls.Add(this.pboxHidePassword);
            this.Controls.Add(this.lblEmptyPass);
            this.Controls.Add(this.lblEmptyUser);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.picboxDesignTop);
            this.Controls.Add(this.picboxDesignbottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogIn_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassworShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesignbottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pboxPassworShow;
        private System.Windows.Forms.PictureBox pboxHidePassword;
        private System.Windows.Forms.Label lblEmptyPass;
        private System.Windows.Forms.Label lblEmptyUser;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.PictureBox picboxDesignTop;
        private System.Windows.Forms.PictureBox picboxDesignbottom;
    }
}

