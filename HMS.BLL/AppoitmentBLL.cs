using HMS.DAL;
using HMS.Entity.Models;
using HMS.Models;
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
        
        public async Task<int> UpdateAppointment(appointment appointment)
        {
            return await AppointmentDAL.UpdateAppointment(appointment);
        }

        public async Task<int> ApprovedAppointment(int appointmentId)
        {
            return await AppointmentDAL.ApprovedAppointment(appointmentId);
        } 
        
        public async Task<int> CompletedAppointment(int appointmentId)
        {
            return await AppointmentDAL.CompletedAppointment(appointmentId);
        }

        public async Task<int> DeleteAppointment(int appointmentid)
        {
            return await AppointmentDAL.DeleteAppointment(appointmentid);
        }
    }
}
