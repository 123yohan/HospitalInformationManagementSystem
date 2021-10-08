using HMS.Entity.Models;
using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
    public class AppointmentReportDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();

        public static List<Staff> GetStaff()
        {
            return _Con.Staffs.Where(x => x.StaffType == "Medical Officer").ToList();
        }

         
        public static dynamic GetAppointments(DateTime FromDate, DateTime ToDate, int StaffNo, bool All)
        {
            var app = _Con.AppointmentManagers.Where(x => x.StaffId == StaffNo).ToList();
              List<appointment> _appointment = new List<appointment>();

            if (All && StaffNo > 0)
            {

                foreach (var item in app)
                {
                    var res = (from a in _Con.Appointments
                                join p in _Con.Patients
                                on a.PatientId equals p.PatientId
                                where a.AppoitmentId == item.AppoitmentId && a.Active == true
                               select new appointment
                                {
                                    PatientName = p.FirstName + " " + p.LastName,
                                    Time = a.Time,
                                    Date = a.Date,

                                }).FirstOrDefault();

                    if (res != null)
                    {
                        _appointment.Add(new appointment
                        {
                            PatientName = res.PatientName,
                            Time = res.Time,
                            Date = res.Date
                    });
                    }
                }

            }
            else if (All == false && StaffNo > 0)
            {
                foreach (var item in app)
                {
                   var res = (from a in _Con.Appointments
                                    join p in _Con.Patients
                                    on a.PatientId equals p.PatientId
                                    where a.AppoitmentId == item.AppoitmentId && a.Date >= FromDate.Date && a.Date <= ToDate.Date && a.Active == true
                              select new appointment
                                    {
                                        PatientName = p.FirstName + " " + p.LastName,
                                        Time = a.Time,
                                        Date = a.Date,

                                    }).FirstOrDefault();

                    if (res != null)
                    {
                        _appointment.Add(new appointment
                        {
                            PatientName = res.PatientName,
                            Time = res.Time,
                            Date = res.Date
                        });
                    }
                }

            }
            return _appointment;
           
        }

        public static dynamic GetAllAppointments()
        {
            var app = _Con.AppointmentManagers.ToList();
            List<appointment> _appointment = new List<appointment>();

            foreach (var item in app)
            {
                var res = (from a in _Con.Appointments
                           join p in _Con.Patients
                           on a.PatientId equals p.PatientId
                           join s in _Con.Staffs on
                           item.StaffId equals s.StaffId
                           where a.AppoitmentId == item.AppoitmentId && a.Active == true && a.IsApproved == false
                           select new appointment
                           {
                               AppoitmentId = a.AppoitmentId,
                               PatientName = p.FirstName + " " + p.LastName,
                               Time = a.Time,
                               Date = a.Date,
                               StaffName = s.FirstName + " " + s.LastName,
                               Status = a.IsApproved == true ? "Approved" : "Pending"
                           }).FirstOrDefault();

                if (res != null)
                {
                    _appointment.Add(new appointment
                    {
                        AppoitmentId = res.AppoitmentId,
                        PatientName = res.PatientName,
                        Time = res.Time,
                        Date = res.Date,
                        StaffName = res.StaffName,
                        Status = res.Status
                    });
                }
            }

            return _appointment;

        }

        public static dynamic GetApprovedAppointments()
        {
            var app = _Con.AppointmentManagers.ToList();
            List<appointment> _appointment = new List<appointment>();

            foreach (var item in app)
            {
                var res = (from a in _Con.Appointments
                           join p in _Con.Patients
                           on a.PatientId equals p.PatientId
                           join s in _Con.Staffs on
                           item.StaffId equals s.StaffId
                           where a.AppoitmentId == item.AppoitmentId && a.Active == true && a.IsApproved == true && a.IsCompleted == false
                           select new appointment
                           {
                               AppoitmentId = a.AppoitmentId,
                               PatientName = p.FirstName + " " + p.LastName,
                               Time = a.Time,
                               Date = a.Date,
                               StaffName = s.FirstName + " " + s.LastName,
                               Status = a.IsApproved == true ? "Approved" : "Pending"
                           }).FirstOrDefault();

                if (res != null)
                {
                    _appointment.Add(new appointment
                    {
                        AppoitmentId = res.AppoitmentId,
                        PatientName = res.PatientName,
                        Time = res.Time,
                        Date = res.Date,
                        StaffName = res.StaffName,
                        Status = res.Status
                    });
                }
            }

            return _appointment;

        }

        public static dynamic GetDeleteAppointments()
        {
            var app = _Con.AppointmentManagers.ToList();
            List<appointment> _appointment = new List<appointment>();

            foreach (var item in app)
            {
                var res = (from a in _Con.Appointments
                           join p in _Con.Patients
                           on a.PatientId equals p.PatientId
                           join s in _Con.Staffs on
                           item.StaffId equals s.StaffId
                           where a.AppoitmentId == item.AppoitmentId && a.Active == false
                           select new appointment
                           {
                               AppoitmentId = a.AppoitmentId,
                               PatientName = p.FirstName + " " + p.LastName,
                               Time = a.Time,
                               Date = a.Date,
                               StaffName = s.FirstName + " " + s.LastName,
                               Status = a.IsApproved == true ? "Approved" : "Pending"
                           }).FirstOrDefault();

                if (res != null)
                {
                    _appointment.Add(new appointment
                    {
                        AppoitmentId = res.AppoitmentId,
                        PatientName = res.PatientName,
                        Time = res.Time,
                        Date = res.Date,
                        StaffName = res.StaffName,
                        Status = res.Status
                    });
                }
            }

            return _appointment;

        }

        public static dynamic GetAppointmentsById(int AppointmentsId)
        {
            var app = _Con.AppointmentManagers.ToList();
            List<appointment> _appointment = new List<appointment>();

            foreach (var item in app)
            {
                var res = (from a in _Con.Appointments
                           join p in _Con.Patients
                           on a.PatientId equals p.PatientId
                           join s in _Con.Staffs on
                           item.StaffId equals s.StaffId
                           where a.AppoitmentId == item.AppoitmentId && a.Active == true && a.AppoitmentId == AppointmentsId
                           select new appointment
                           {
                               AppoitmentId = a.AppoitmentId,
                               PatientId = p.PatientId,
                               PatientName = p.FirstName + " " + p.LastName,
                               StaffId = s.StaffId,
                               StaffName = s.FirstName + " " + s.LastName,
                               Time = a.Time,
                               Date = a.Date,

                           }).FirstOrDefault();

                if (res != null)
                {
                    _appointment.Add(new appointment
                    {
                        PatientId = res.PatientId,
                        AppoitmentId = res.AppoitmentId,
                        PatientName = res.PatientName,
                        StaffId = res.StaffId,
                        StaffName = res.StaffName,
                        Time = res.Time,
                        Date = res.Date
                    });
                }
            }

            return _appointment;

        }

    }
}
