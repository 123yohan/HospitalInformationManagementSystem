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
    public partial class Appointment_ReportPL : Form
    {
        BLL.AppointmentReportBLL appointmentReportBLL;
        public Appointment_ReportPL()
        {
            InitializeComponent();
            appointmentReportBLL = new BLL.AppointmentReportBLL();

            appointmentReportBLL.GetStaff(cmbStaff);
            cmbStaff.SelectedIndex = -1;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cmbStaff.SelectedIndex >= 0 && chkAll.Checked)
            {
                appointmentReportBLL.GetAppointments(dtpFrom.Value,dtpTo.Value,Convert.ToInt32( cmbStaff.SelectedValue),chkAll.Checked,dgvAppointmentReport);
            }
            else
            {
                appointmentReportBLL.GetAppointments(dtpFrom.Value, dtpTo.Value, Convert.ToInt32(cmbStaff.SelectedValue), false, dgvAppointmentReport);
            }
        }
    }
}
