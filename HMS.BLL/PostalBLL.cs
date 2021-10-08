using HMS.DAL;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.BLL
{
    public class PostalBLL
    {
        public DataGridView GetAllPostals(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = PostalDAL.GetAllPostals();

                return dgv;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Postal> GetPostalsById(int id)
        {
            try
            {
                return PostalDAL.GetPostalsById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddPostal(Postal postal)
        {
            try
            {
                return PostalDAL.AddPostal(postal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdatePostal(Postal postal)
        {
            try
            {
                return await PostalDAL.UpdatePostal(postal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeletePostal(int Id)
        {
            try
            {
                return PostalDAL.DeletePostal(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
