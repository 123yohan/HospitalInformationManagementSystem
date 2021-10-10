using HMS.BLL;
using HMS.DAL;
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
    public partial class ComplaintsViewPL : Form
    {
        ComplainBLL complainBLL;
        public ComplaintsViewPL()
        {
            InitializeComponent();
            complainBLL = new ComplainBLL();
            PageAccess();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PageAccess()
        {
            var res = LoginDAL.lstUserRole.Where(x => x.PageName == "Complatine").FirstOrDefault();
            if (res != null)
            {
                if (res.AddCommand == true)
                {
                    btnAddComplains.Visible = true;
                }

                if (res.EditCommand == true)
                {
                    dgvComplaint.Columns[0].Visible = true;
                }

                if (res.DeleteCommand == true)
                {
                    dgvComplaint.Columns[8].Visible = true;
                }
            }
        }


        private void btnAddComplains_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AppoitmentPL))
                {
                    f.Activate();
                    return;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(ComplaintsAddPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new ComplaintsAddPL(true, GetComplaint,0);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void ComplaintsViewPL_Load(object sender, EventArgs e)
        {
            GetComplaint();
        }

        public int GetComplaint()
        {
            complainBLL.GetComplaints(dgvComplaint);
            return 0;
        }

        private void dgvComplaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvComplaint.Columns["Edite"].Index && e.RowIndex >= 0)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(ComplaintsAddPL))
                    {
                        f.Activate();
                        return;
                    }
                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(ComplaintsAddPL))
                    {
                        f.Activate();
                        return;
                    }
                }

                int Id = Convert.ToInt32(dgvComplaint.Rows[e.RowIndex].Cells[1].Value);
                Form frm = new ComplaintsAddPL(false,GetComplaint, Id);
                frm.MdiParent = MasterForm.ActiveForm;
                frm.Show();


            }



            if (e.ColumnIndex == dgvComplaint.Columns["DELETE"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int Id = Convert.ToInt32(dgvComplaint.Rows[e.RowIndex].Cells[1].Value);
                    if (DeleteComplaint(Id) > 0)
                    {
                        MessageBox.Show("Delete Succesfully", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetComplaint();
                    }
                }


            }

            
        }

        public int DeleteComplaint(int Id)
        {
            return complainBLL.DeleteComplaint(Id);
        }
    }
}
