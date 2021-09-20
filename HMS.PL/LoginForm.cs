using HMS.DAL;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.PL
{
    public partial class btnExit : Form
    {
        public btnExit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please Enter User Name", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Password", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            var userAcc = new UserAccount
            {
                Username = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };


           var res =  LoginDAL.Login(userAcc);

            if(res == -1)
            {
                MessageBox.Show("User Name Invalid", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if(res == -2)
            {
                MessageBox.Show("Password Invalid", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if(res > 0)
            {
                MasterForm MF = new MasterForm();
                MF.Show();
                this.Hide();
            }

            
        }
    }
}
