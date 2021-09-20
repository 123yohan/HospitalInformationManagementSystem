using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
    public class AppointmentDAL
    {

        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();

        public static List<Patient> GetPatients(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return _Con.Patients.ToList();
            }

            var patientCollection = _Con.Patients as IQueryable<Patient>;

            if (!string.IsNullOrWhiteSpace(Name))
            {
                Name = Name.Trim();
                patientCollection = patientCollection.Where(x => x.FirstName.Contains(Name));
            }

            return patientCollection.ToList();

        }

        public static List<Staff> GetStaffs(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return _Con.Staffs.Where(x => x.StaffType == "Doctor").ToList();
            }

            var staffCollection = _Con.Staffs as IQueryable<Staff>;

            staffCollection = staffCollection.Where(x => x.StaffType == "Doctor");


            if (!string.IsNullOrWhiteSpace(Name))
            {
                Name = Name.Trim();
                staffCollection = staffCollection.Where(x => x.FirstName.Contains(Name));
            }

            return staffCollection.ToList();

        }


        public static async Task<int> AddAppointment(Appointment appointment, int StaffId)
        {
            _Con.Appointments.Add(appointment);

            var res = await _Con.SaveChangesAsync();

            var am = new AppointmentManager
            {
                AppoitmentId = appointment.AppoitmentId,
                StaffId = StaffId
            };

            _Con.AppointmentManagers.Add(am);
            return await _Con.SaveChangesAsync();

        }
    }
}
