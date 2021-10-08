using HMS.BLL;
using HMS.DAL;
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
            Form frm = new StaffPL(LoadDataDgvStaff, 0);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void StaffDetailsPL_Load(object sender, EventArgs e)
        {
            PageAccess();
            LoadDataDgvStaff();
        }

        public void PageAccess()
        {
            var res = LoginDAL.lstUserRole.Where(x => x.PageName == "Staff").FirstOrDefault();
            if(res != null)
            {
                if (res.AddCommand == true)
                {
                    btnAddStaff.Visible = true;
                }

                if (res.EditCommand == true)
                {
                    dgvStaff.Columns[0].Visible = true;
                }

                if (res.DeleteCommand == true)
                {
                    dgvStaff.Columns[13].Visible = true;
                }
            }
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

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStaff.Columns["Edite"].Index && e.RowIndex >= 0)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AddPostalPL))
                    {
                        f.Activate();
                        return;
                    }
                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(AddPostalPL))
                    {
                        f.Activate();
                        return;
                    }
                }

                int Id = Convert.ToInt32(dgvStaff.Rows[e.RowIndex].Cells[1].Value);
                Form frm = new StaffPL(LoadDataDgvStaff, Id);
                frm.MdiParent = MasterForm.ActiveForm;
                frm.Show();


            }



            if (e.ColumnIndex == dgvStaff.Columns["DELETE"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int Id = Convert.ToInt32(dgvStaff.Rows[e.RowIndex].Cells[1].Value);
                    if (DeleteAppoiment(Id) > 0)
                    {
                        MessageBox.Show("Delete Succesfully", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataDgvStaff();
                    }
                }


            }
        }

        public int DeleteAppoiment(int id)
        {
            return staffBLL.DeleteStaff(id);
        }
    }
}
