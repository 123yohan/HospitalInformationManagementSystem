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
    public class ComplainBLL
    {
      

        public async Task<int> AddComplain(Complaint complaint)
        {
            return await ComplainDAL.AddComplain(complaint);
        }  
        
        public async Task<int> UpdateComplain(Complaint complaint)
        {
            return await ComplainDAL.UpdatedComplain(complaint);
        }

        public DataGridView GetComplaints(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ComplainDAL.GetComplaints();
            dgv.Columns[6].DefaultCellStyle.Format = "yyyy MMMM dd ";

            return dgv;
        }

        public List<complaints> GetComplaints(int Id)
        {
          return ComplainDAL.GetComplaints(Id);

        }

        public async Task<int> UpdatedComplain(Complaint complaint)
        {
            return await ComplainDAL.UpdatedComplain(complaint);
        }

        public int DeleteComplaint(int Id)
        {
            return ComplainDAL.DeleteComplaint(Id);
        }
    }
}
