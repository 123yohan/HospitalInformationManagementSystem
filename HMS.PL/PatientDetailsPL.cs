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
    public partial class PatientDetailsPL : Form
    {
        PatientBLL patientBLL;
        public PatientDetailsPL()
        {
            InitializeComponent();
            patientBLL = new PatientBLL();
            PageAccess();
            LoadDataDgvStaff();
        }

        public void PageAccess()
        {
            var res = LoginDAL.lstUserRole.Where(x => x.PageName == "Patient").FirstOrDefault();
            if (res != null)
            {
                if (res.AddCommand == true)
                {
                    btnAddPaitent.Visible = true;
                }

                if (res.EditCommand == true)
                {
                    dgvPatient.Columns[0].Visible = true;
                }

                if (res.DeleteCommand == true)
                {
                    dgvPatient.Columns[8].Visible = true;
                }
            }
        }

        public int LoadDataDgvStaff()
        {
            patientBLL.GetPatient(dgvPatient);
            return 0;
        }

        private void btnAddPaitent_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PatientAddPL))
                {
                    f.Activate();
                    return;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(PatientAddPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new PatientAddPL(LoadDataDgvStaff,0);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientDetailsPL_Load(object sender, EventArgs e)
        {
           
        }

        public int DeletePatient(int id)
        {
            return patientBLL.DeletePatient(id);
        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPatient.Columns["Edite"].Index && e.RowIndex >= 0)
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

                int Id = Convert.ToInt32(dgvPatient.Rows[e.RowIndex].Cells[1].Value);
                Form frm = new PatientAddPL(LoadDataDgvStaff, Id);
                frm.MdiParent = MasterForm.ActiveForm;
                frm.Show();


            }



            if (e.ColumnIndex == dgvPatient.Columns["DELETE"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int Id = Convert.ToInt32(dgvPatient.Rows[e.RowIndex].Cells[1].Value);
                    if (DeletePatient(Id) > 0)
                    {
                        MessageBox.Show("Delete Succesfully", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataDgvStaff();
                    }
                }


            }
        }
    }
}
