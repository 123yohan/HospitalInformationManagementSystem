using HMS.BLL;
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
    public partial class AppointmentViewPL : Form
    {
        BLL.AppointmentReportBLL appointmentReportBLL;
        AppoitmentBLL appoitmentBLL;
        public AppointmentViewPL()
        {
            InitializeComponent();
            appointmentReportBLL = new BLL.AppointmentReportBLL();

            appoitmentBLL = new AppoitmentBLL();
            appointmentReportBLL.GetAllAppointments(dgvAppointmentReport);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentViewPL_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAppoiment_Click(object sender, EventArgs e)
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
                if (f.GetType() == typeof(AppoitmentPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new AppoitmentPL(0);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void dgvAppointmentReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex == 0)
            {
              
            }
        }

        private async void dgvAppointmentReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.ColumnIndex == dgvAppointmentReport.Columns["Edite"].Index && e.RowIndex >= 0)
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
                    if (f.GetType() == typeof(AppoitmentPL))
                    {
                        f.Activate();
                        return;
                    }
                }

                int AppoimentId = Convert.ToInt32(dgvAppointmentReport.Rows[e.RowIndex].Cells[8].Value);
                Form frm = new AppoitmentPL(AppoimentId);
                frm.MdiParent = MasterForm.ActiveForm;
                frm.Show();

               
            }
            
            if (e.ColumnIndex == dgvAppointmentReport.Columns["DELETE"].Index && e.RowIndex >= 0)
            {
                int aid = Convert.ToInt32( dgvAppointmentReport.Rows[e.RowIndex].Cells[8].Value);
                if (await DeleteAppoiment(aid) > 0)
                {
                    MessageBox.Show("System Alert", "Delete Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    appointmentReportBLL.GetAllAppointments(dgvAppointmentReport);
                }
            }

          
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DataGridViewRow row = dgvAppointmentReport.Rows[e.RowIndex];
                row.Cells["Approved"].Value = !Convert.ToBoolean(row.Cells["Approved"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["Approved"].Value))
                {

                    await appoitmentBLL.ApprovedAppointment(Convert.ToInt32(row.Cells[8].Value));
                    appointmentReportBLL.GetAllAppointments(dgvAppointmentReport);
                }
            }




        }

        public async Task<int> DeleteAppoiment(int id)
        {
           return await appoitmentBLL.DeleteAppointment(id);
        }


    }
}
