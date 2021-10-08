
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS;
using HMS.Entity.Models;
using HMS.Models;
using HMS.Other;
using Scrypt;

namespace HMS.DAL
{
   public class StaffDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();
        static int Result = 0;

        public static List<staff> GetStaffs()
        {
            try
            {
                return (from s in _Con.Staffs
                        join a in _Con.UserAccounts on s.StaffId equals a.EmployeeId
                        join u in _Con.UserRoles on a.UserRoleId equals u.RoleId
                        where a.Status == "Staff" && a.Active == true && s.Active == true
                        select new staff
                        {
                            StaffId = s.StaffId,
                            FirstName = s.FirstName,
                            LastName = s.LastName,
                            StaffType = s.StaffType,
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
        
        public static List<staff> GetStaffsById(int Id)
        {
            try
            {
                return (from s in _Con.Staffs
                        join a in _Con.UserAccounts on s.StaffId equals a.EmployeeId
                        join u in _Con.UserRoles on a.UserRoleId equals u.RoleId
                        where a.Status == "Staff" && a.Active == true && s.Active == true && s.StaffId == Id
                        select new staff
                        {
                            StaffId = s.StaffId,
                            FirstName = s.FirstName,
                            LastName = s.LastName,
                            StaffType = s.StaffType,
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

        public static int NewStaff(Staff staff, UserAccount userAccount)
        {
            try
            {
                var res = _Con.Staffs.Any(x => x.Nic == staff.Nic && x.Active == true || x.Email == staff.Email && x.Active == true);
                if (res)
                {
                    Result = 99;
                }
                else
                {
                    var _staff = _Con.Staffs.Add(staff);
                    Result = _Con.SaveChanges();

                    ScryptEncoder encoder = new ScryptEncoder();
                    userAccount.EmployeeId = _staff.StaffId;
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

        public static int UpdateStaff(Staff staff, UserAccount userAccount)
        {
            try
            {
                var duplicate = _Con.Staffs.Any(x => x.Nic == staff.Nic && x.Active == true || x.Email == staff.Email && x.Active == true && x.StaffId != staff.StaffId);
                if(duplicate)
                {
                    Result = 99;
                }
                else
                {
                    var res = _Con.Staffs.Find(staff.StaffId);
                    res.FirstName = staff.FirstName;
                    res.LastName = staff.LastName;
                    res.Address = staff.Address;
                    res.Gender = staff.Gender;
                    res.MobileNo = staff.MobileNo;
                    res.Nic = staff.Nic;
                    res.Email = staff.Email;
                   

                    var res2 = _Con.UserAccounts.Where(x => x.EmployeeId == staff.StaffId).FirstOrDefault();
                    if(res2 != null)
                    {
                        res2.Password = userAccount.Password;
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

        public static int DeleteStaff(int StaffId)
        {
            try
            {
                var res = _Con.Staffs.Find(StaffId);
                res.Active = false;

                var res2 = _Con.UserAccounts.Where(x=>x.EmployeeId == StaffId).FirstOrDefault();
                if(res2 != null)
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
