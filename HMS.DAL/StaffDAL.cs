
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS;
using HMS.Entity.Models;
using HMS.Other;

namespace HMS.DAL
{
   public class StaffDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();
        static int Result = 0;

        public static List<Staff> GetStaffs()
        {
            try
            {
                return _Con.Staffs.Where(x => x.Active == true).ToList();
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

                    userAccount.EmployeeId = _staff.StaffId;
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

        public static int UpdateStaff(Staff staff)
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
                    res.UserRoleId = staff.UserRoleId;

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
