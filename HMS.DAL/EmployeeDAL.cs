using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS;
using HMS.Other;

namespace HMS.DAL
{
   public class EmployeeDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();
        static int Result = 0;

        public static List<TblEmployee> GetEmployeee()
        {
            try
            {
                return _Con.TblEmployees.Where(x => x.Active == true).ToList();
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        public static int NewEmployee(TblEmployee tblEmployee)
        {
            try
            {
                var res = _Con.TblEmployees.Any(x => x.EmpName == tblEmployee.EmpName && x.Active == true);
                if(res)
                {
                    Result = 99;
                }
                else
                {
                    _Con.TblEmployees.Add(tblEmployee);
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

        public static int UpdateEmployee(TblEmployee tblEmployee)
        {
            try
            {
                var duplicate = _Con.TblEmployees.Any(x => x.EmpName == tblEmployee.EmpName && x.EmpId != tblEmployee.EmpId);
                if(duplicate)
                {
                    Result = 99;
                }
                else
                {
                    var res = _Con.TblEmployees.Find(tblEmployee.EmpId);
                    res.EmpName = tblEmployee.EmpName;
                    res.EmpAddress = tblEmployee.EmpAddress;
                    res.EmpContactNo = tblEmployee.EmpContactNo;
                    res.EmpGender = tblEmployee.EmpGender;
                    res.EmpContactNo = tblEmployee.EmpContactNo;
                    res.UserGroupId = tblEmployee.UserGroupId;

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

        public static int DeleteEmployee(int EmpId)
        {
            try
            {
                var res = _Con.TblEmployees.Find(EmpId);
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

        public static List<TblUserGroup> GetUserGroup()
        {
            try
            {
              return _Con.TblUserGroups.Where(x => x.Active == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
