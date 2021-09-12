using HMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using HMS.Entity.Models;

namespace HMS.BLL
{
    class EmployeeBLL
    {
        public DataGridView GetEmployeee(DataGridView dgvEmployee)
        {
            try
            {
                dgvEmployee.DataSource = EmployeeDAL.GetEmployeee();
                dgvEmployee.AutoGenerateColumns = false;
                return dgvEmployee;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ComboBox GetUserGroup(ComboBox cmbUserGroup)
        {
            try
            {
                cmbUserGroup.DataSource = EmployeeDAL.GetUserGroup();
                cmbUserGroup.DisplayMember = "Name";
                cmbUserGroup.ValueMember = "UserGroupId";
                return cmbUserGroup;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddEmployee(TblEmployee tblEmployee)
        {
            try
            {
                return EmployeeDAL.NewEmployee(tblEmployee);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateEmployee(TblEmployee tblEmployee)
        {
            try
            {
                return EmployeeDAL.UpdateEmployee(tblEmployee);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeleteEmployee(int EmpId)
        {
            try
            {
                return EmployeeDAL.DeleteEmployee(EmpId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
