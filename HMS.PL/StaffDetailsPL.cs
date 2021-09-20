using HMS.BLL;
using HMS.Models;
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

         StaffBLL staffBLL;
        public StaffDetailsPL()
        {
            InitializeComponent();
            staffBLL = new StaffBLL();
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
            Form frm = new StaffPL(LoadDataDgvStaff);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void StaffDetailsPL_Load(object sender, EventArgs e)
        {
            LoadDataDgvStaff();
        }

        public int LoadDataDgvStaff()
        {
            staffBLL.GetStaffs(dgvStaff);
            return 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            staffBLL.GetStaffs(dgvStaff);
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(var res in dgvStaff.SelectedRows)
            {
               
            }
        }
    }
}
