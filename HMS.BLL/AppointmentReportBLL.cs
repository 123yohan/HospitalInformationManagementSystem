using HMS.DAL;
using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.BLL
{
   public class AppointmentReportBLL
    {
        public ComboBox GetStaff(ComboBox cmbStaff)
        {
            cmbStaff.DataSource = AppointmentReportDAL.GetStaff();
            cmbStaff.DisplayMember = "FirstName" ;
            cmbStaff.ValueMember = "StaffId";

            return cmbStaff;
        }

        public DataGridView GetAppointments(DateTime FromDate, DateTime ToDate, int StaffNo, bool All, DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = AppointmentReportDAL.GetAppointments(FromDate, ToDate, StaffNo, All);
            dgv.Columns[1].DefaultCellStyle.Format = "yyyy MMMM dd ";
            dgv.Columns[2].DefaultCellStyle.Format = "h: mm tt";
            return dgv;
        }  
        
        public DataGridView GetAllAppointments(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = AppointmentReportDAL.GetAllAppointments();
            dgv.Columns[3].DefaultCellStyle.Format = "yyyy MMMM dd ";
            dgv.Columns[4].DefaultCellStyle.Format = "h: mm tt";
            return dgv;
        }


        public List<appointment> GetAllAppointments(int AppointmentsId)
        {
          return  AppointmentReportDAL.GetAppointmentsById(AppointmentsId);
           
        }

    }
}
