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
    public partial class UserLoginPL : Form
    {
        public UserLoginPL()
        {
            InitializeComponent();
        }

        private void UserLoginPL_Load(object sender, EventArgs e)
        {
            dtpTime.CustomFormat = "h:mm tt";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
