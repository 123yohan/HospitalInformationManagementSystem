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
    public partial class DeleteAppoinmentRecordPL : Form
    {

        AppointmentReportBLL appointmentReportBLL;
        public DeleteAppoinmentRecordPL()
        {
            InitializeComponent();
            appointmentReportBLL = new AppointmentReportBLL();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteAppoinmentRecordPL_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        public void LoadGridView()
        {
            appointmentReportBLL.GetDeleteAppointments(dgvAppointmentReport);
        }
    }
}
