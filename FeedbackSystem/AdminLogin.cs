using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackSystem
{
    public partial class AdminLogin : Form
    {
        private Admin admin = new Admin();
        public AdminLogin()
        {
            InitializeComponent();
        }

        /*
         * This method checks the validation for Login Screen.
         * If the conditions are matched, user is redirected to the admin panel.
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                if(txtUsername.Text == "admin" && txtPassword.Text == "pass")
                {
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials\nPlease Enter Correct Credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter your Credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }
    }
}
