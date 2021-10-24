using HMS.Entity.Models;
using HMS.Models;
using Scrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
    public class PatientDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();
        static int Result = 0;

        public static List<patient> GetPatient()
        {
            try
            {
                return (from s in _Con.Patients
                        join a in _Con.UserAccounts on s.PatientId equals a.EmployeeId
                        join u in _Con.UserRoles on a.UserRoleId equals u.RoleId
                        where a.Status == "Patient" && a.Active == true && s.Active == true
                        select new patient
                        {
                            PatientId = s.PatientId,
                            FirstName = s.FirstName,
                            LastName = s.LastName,
                            UserType = s.UserType,
                            Address = s.Address,
                            MobileNo = s.MobileNo,
                            Nic = s.Nic,
                            Email = s.Email,
                            Gender = s.Gender,
                            UserRoleName = u.Name,
                            UserName = a.Username,
                            Active = s.Active,
                            CreatedDateTime = s.CreatedDateTime

                        }).ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<patient> GetPatientById(int Id)
        {
            try
            {
                return (from s in _Con.Patients
                        join a in _Con.UserAccounts on s.PatientId equals a.EmployeeId
                        join u in _Con.UserRoles on a.UserRoleId equals u.RoleId
                        where a.Status == "Patient" && a.Active == true && s.Active == true && s.PatientId == Id
                        select new patient
                        {
                            PatientId = s.PatientId,
                            FirstName = s.FirstName,
                            LastName = s.LastName,
                            UserType = s.UserType,
                            Address = s.Address,
                            MobileNo = s.MobileNo,
                            Nic = s.Nic,
                            Email = s.Email,
                            Gender = s.Gender,
                            UserRoleName = u.Name,
                            UserName = a.Username,
                            Active = s.Active,
                            CreatedDateTime = s.CreatedDateTime

                        }).ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static int NewPatient(Patient patient, UserAccount userAccount)
        {
            try
            {
                var res = _Con.Staffs.Any(x => x.Nic == patient.Nic && x.Active == true || x.Email == patient.Email && x.Active == true);
                if (res)
                {
                    Result = 99;
                }
                else
                {
                    var _staff = _Con.Patients.Add(patient);
                    Result = _Con.SaveChanges();

                    ScryptEncoder encoder = new ScryptEncoder();
                    userAccount.EmployeeId = _staff.PatientId;
                    userAccount.Password = encoder.Encode(userAccount.Password);
                    _Con.UserAccounts.Add(userAccount);
                    Result = _Con.SaveChanges();
                }
            }
            catch (Exception)
            {
                Result = 0;
                throw;
            }
            return Result;
        }

        public static int UpdatePatient(Patient patient, UserAccount userAccount)
        {
            try
            {
                var duplicate = _Con.Staffs.Any(x => x.Nic == patient.Nic && x.Active == true || x.Email == patient.Email && x.Active == true && x.StaffId != patient.PatientId);
                if (duplicate)
                {
                    Result = 99;
                }
                else
                {
                    var res = _Con.Patients.Find(patient.PatientId);
                    res.FirstName = patient.FirstName;
                    res.LastName = patient.LastName;
                    res.Address = patient.Address;
                    res.Gender = patient.Gender;
                    res.MobileNo = patient.MobileNo;
                    res.Nic = patient.Nic;
                    res.Email = patient.Email;


                    var res2 = _Con.UserAccounts.Where(x => x.EmployeeId == patient.PatientId).FirstOrDefault();
                    if (res2 != null)
                    {
                        ScryptEncoder encoder = new ScryptEncoder();
                        res2.Username = userAccount.Username;
                        res2.Password = encoder.Encode(userAccount.Password);
                        res2.UserRoleId = userAccount.UserRoleId;
                    }

                    Result = _Con.SaveChanges();
                }

            }
            catch (Exception)
            {
                Result = 0;
                throw;
            }
            return Result;
        }

        public static int DeletePatient(int PatientId)
        {
            try
            {
                var res = _Con.Patients.Find(PatientId);
                res.Active = false;

                var res2 = _Con.UserAccounts.Where(x => x.EmployeeId == PatientId).FirstOrDefault();
                if (res2 != null)
                {
                    res2.Active = false;
                }
                Result = _Con.SaveChanges();

            }
            catch (Exception)
            {
                Result = 0;
                throw;
            }
            return Result;
        }

        public static List<UserRole> GetUserGroup()
        {
            try
            {
                return _Con.UserRoles.Where(x => x.Active == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
