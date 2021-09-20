using HMS.DAL;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.BLL
{
   public class AppoitmentBLL
    {
        public ListView GetStaff(ListView lstStaff, string Name)
        {
            var res = AppointmentDAL.GetStaffs(Name);
            lstStaff.Items.Clear();
            foreach (var item in res)
            {
                ListViewItem ListItem = new ListViewItem(item.StaffId.ToString());
                ListItem.SubItems.Add(item.FirstName + " " + item.LastName);
                lstStaff.Items.Add(ListItem);
            }

            return lstStaff;
        }

        public ListView GetPatients(ListView lstPatient, string Name)
        {
            var res = AppointmentDAL.GetPatients(Name);
            lstPatient.Items.Clear();
            foreach (var item in res)
            {
                ListViewItem ListItem = new ListViewItem(item.PatientId.ToString());
                ListItem.SubItems.Add(item.FirstName + " " + item.LastName);
                lstPatient.Items.Add(ListItem);
            }

            return lstPatient;
        }

        public async Task<int> AddAppointment(Appointment appointment, int StaffId)
        {
            return await AppointmentDAL.AddAppointment(appointment, StaffId);
        }
    }
}
