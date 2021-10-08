using HMS.Entity.Models;
using HMS.Models;
using HMS.Other;
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
                return _Con.Staffs.Where(x => x.StaffType == "Medical Officer").ToList();
            }

            var staffCollection = _Con.Staffs as IQueryable<Staff>;

            staffCollection = staffCollection.Where(x => x.StaffType == "Medical Officer");


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

        public static async Task<int> UpdateAppointment(appointment appointment)
        {
            var res = _Con.Appointments.Find(appointment.AppoitmentId);

            res.PatientId = appointment.PatientId;
            res.Time = appointment.Time;
            res.Date = appointment.Date;
            res.UpdateBy = HMSComman.UserAccId;
            res.UpdateDate = DateTime.Now;

            var res2 = _Con.AppointmentManagers.Where(x => x.AppoitmentId == appointment.AppoitmentId).FirstOrDefault();
            if (res2 != null)
            {
                res2.StaffId = appointment.StaffId;
                return await _Con.SaveChangesAsync();
            }

            return 0;

        }

        public static async Task<int> ApprovedAppointment(int appointmentId)
        {
            var res = _Con.Appointments.Find(appointmentId);
            res.IsApproved = true;
            return await _Con.SaveChangesAsync();
        }

        public static async Task<int> CompletedAppointment(int appointmentId)
        {
            var res = _Con.Appointments.Find(appointmentId);
            res.IsCompleted = true;
            return await _Con.SaveChangesAsync();
        }

        public static async Task<int> DeleteAppointment(int AppoitmentId)
        {
            var res = _Con.Appointments.Where(x => x.AppoitmentId == AppoitmentId && x.Active == true).FirstOrDefault();
            if (res != null)
            {
                res.Active = false;
                return await _Con.SaveChangesAsync();
            }

            return 0;

        }
    }
}
