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
    public partial class StaffDetailsPL : Form
    {
        public StaffDetailsPL()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(StaffPL))
                {
                    f.Activate();
                    return;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(StaffPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new StaffPL();
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }
    }
}
