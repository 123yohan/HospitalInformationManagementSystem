using HMS.DAL;
using HMS.Entity.Models;
using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.BLL
{
   public class StaffBLL
    {
        public DataGridView GetStaffs(DataGridView dgvEmployee)
        {
            try
            {
                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.DataSource = StaffDAL.GetStaffs();
                return dgvEmployee;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<staff> GetStaffsById(int Id)
        {
            try
            {
               return  StaffDAL.GetStaffsById(Id);
                

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
                cmbUserGroup.DataSource = StaffDAL.GetUserGroup();
                cmbUserGroup.DisplayMember = "Name";
                cmbUserGroup.ValueMember = "RoleId";
                return cmbUserGroup;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddStaff(Staff staff, UserAccount userAccount)
        {
            try
            {
                return StaffDAL.NewStaff(staff, userAccount);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateStaff(Staff staff, UserAccount userAccount)
        {
            try
            {
                return StaffDAL.UpdateStaff(staff, userAccount);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeleteStaff(int StaffId)
        {
            try
            {
                return StaffDAL.DeleteStaff(StaffId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
