using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asset_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                //string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                var userLevel = new User().AuthenticateUser(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Login Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //this.Hide();
                if (userLevel == "Admin")
                {
                    //show admin window
                    this.Hide();
                    MainFormAdmin aa = new MainFormAdmin();
                    aa.Show();
                    //

                }
                else if (userLevel == "Custodian")
                {
                    this.Hide();
                    MainFormCustodian cc = new MainFormCustodian();
                    cc.Show();

                }

                else if (String.IsNullOrEmpty(txtUsername.Text) && String.IsNullOrEmpty(txtPassword.Text))
                {

                    MessageBox.Show("The username or password you have entered is incorrect", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (String.IsNullOrEmpty(txtUsername.Text))
                {

                    MessageBox.Show("Please enter correct username", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (String.IsNullOrEmpty(txtPassword.Text))
                {

                    MessageBox.Show("Please enter correct password", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("The username or password you have entered is incorrect", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }



        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtUsername.ForeColor = Color.Black;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtPassword.ForeColor = Color.Black;


        }

        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text = "password";

            }
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = "username";

            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.Text = string.Empty;
        }


    }
}
