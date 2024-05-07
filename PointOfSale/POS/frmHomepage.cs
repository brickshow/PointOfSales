using System;
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
    public partial class frmHomepage : Form
    {
        frmAddEmployee addEmp = new frmAddEmployee();
        frmLogIn logIn = new frmLogIn();
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Check if the user confirm using OK button
            if (result == DialogResult.OK)
            {
                this.Hide();
                logIn.thisShow();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this app?", "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Check if the user confirm using OK button
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }


        public void profile(string _profile)
        {
            lblProfile.Text = _profile;
            lblProfile.Location = new Point(59, 11);
        }

        private void btnEmpMan_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            lblDashboard.Hide();
            addEmp.TopLevel = false;
            pnlMain.Controls.Add(addEmp);
            addEmp.Dock = DockStyle.Fill;
            addEmp.Show();
        }
    }
}
