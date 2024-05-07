﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmLogIn : Form
    {
        List<clsEMPLOYEE> logInValidation = new List<clsEMPLOYEE>();//List to store login Info
        List<clsAdminInfo> validateAdmin;
        public frmLogIn()
        {
            InitializeComponent();

            validateAdmin = new List<clsAdminInfo>();
            //Error Indicator
            lblIndicator.Hide();
            lblEmptyPass.Hide();
            lblEmptyUser.Hide();

            validateAdmin.Add(new clsAdminInfo
            {
                Role = "Administrator",
                AdminID = 1,
                Username = "Admin",
                Password = "Admin",
            });

            //Leave and Enter event in just two event handler
            EventHandler textBoxEnterHandler = (sender, e) => {
                if (sender is TextBox textBox)
                {
                    if (textBox.Text == textBox.Tag.ToString())
                    {
                        textBox.Clear();
                        textBox.ForeColor = SystemColors.ControlText;
                        if (textBox == txtboxUsername)
                        {
                            lblEmptyUser.Hide();
                            lblEmptyPass.Hide();
                            lblIndicator.Hide();
                        }
                    }
                }
            };

            EventHandler textBoxLeaveHandler = (sender, e) => {
                if (sender is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = textBox.Tag.ToString();
                        textBox.ForeColor = SystemColors.GrayText;
                        if (textBox == txtboxUsername)
                        {
                            lblEmptyUser.Show();
                        }
                    }
                }
            };

            txtboxUsername.Enter += textBoxEnterHandler;
            txtboxUsername.Leave += textBoxLeaveHandler;
            txtboxPassword.Enter += textBoxEnterHandler;
            txtboxPassword.Leave += textBoxLeaveHandler;

            // Set tag values for each TextBox
            txtboxUsername.Tag = "Username";
            txtboxPassword.Tag = "Password";

            //Lambda expression for show and hide password
            pboxPassworShow.MouseDown += (sender, e) =>
            {
                txtboxPassword.PasswordChar = '\0';
                pboxHidePassword.BringToFront();
            };
            pboxPassworShow.MouseUp += (sender, e) =>
            {
                pboxPassworShow.BringToFront();
                txtboxPassword.PasswordChar = '•';
            };

            this.KeyPreview = true;//Enable the key preview for the form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Execute the enter events
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control actCtr = ActiveControl;
                if ((TextBox)sender != txtboxPassword)
                {
                    SelectNextControl(actCtr, true, true, true, true);
                }
                else logIn();
            }
        }

        //Log In method
        public void logIn()
        {
            bool correctinfo = (from Admin in validateAdmin
                                where txtboxUsername.Text == Admin.Username
                                && txtboxPassword.Text == Admin.Password
                                select Admin).Any();//Log in ussing LINQ
            var selectRole = (from Admin in validateAdmin
                              where Admin.Role == "Administrator"
                              select Admin);
            if (correctinfo)
            {
                frmHomepage homepage = new frmHomepage();//Call Out the homepage
                txtboxUsername.Focus();
                homepage.Show();
                this.Hide();
                // Get the first administrator (assuming there's only one)
                var admin = selectRole.FirstOrDefault();

                if (admin != null)
                {
                    homepage.profile(admin.Role); // Pass the role to the homepage
                }
            }
            else lblIndicator.Show();
        }

        private void frmLogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if the user used escape keys
            if (e.KeyChar == (char)Keys.Escape)
            {
                //Show a confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Check if the user confirm using OK button
                if (result == DialogResult.OK) this.Close();
            }
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {
            lblIndicator.Hide();
            lblEmptyPass.Hide();
            lblEmptyUser.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            logIn();
        }

        public void thisShow()
        {
            this.Show();
        }

    }

}
