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
    public class PatientBLL
    {
        public DataGridView GetPatient(DataGridView dgvEmployee)
        {
            try
            {
                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.DataSource = PatientDAL.GetPatient();
                dgvEmployee.Columns[12].DefaultCellStyle.Format = "yyyy MMMM dd ";
                return dgvEmployee;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<patient> GetPatientById(int Id)
        {
            try
            {
                return PatientDAL.GetPatientById(Id);


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
                cmbUserGroup.DataSource = PatientDAL.GetUserGroup();
                cmbUserGroup.DisplayMember = "Name";
                cmbUserGroup.ValueMember = "RoleId";
                return cmbUserGroup;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddPatient(Patient patient, UserAccount userAccount)
        {
            try
            {
                return PatientDAL.NewPatient(patient, userAccount);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdatePatient(Patient patient, UserAccount userAccount)
        {
            try
            {
                return PatientDAL.UpdatePatient(patient, userAccount);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeletePatient(int PatientId)
        {
            try
            {
                return PatientDAL.DeletePatient(PatientId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
