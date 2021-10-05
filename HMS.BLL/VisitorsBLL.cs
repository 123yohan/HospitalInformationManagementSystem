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
    class VisitorsBLL
    {
        public DataGridView GetVisitors(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = VisitorsDAL.GetVisitors();
            dgv.Columns[8].DefaultCellStyle.Format = "yyyy MMMM dd ";
            dgv.Columns[9].DefaultCellStyle.Format = "h: mm tt";
            dgv.Columns[10].DefaultCellStyle.Format = "h: mm tt";
            return dgv;
        }

        public  int AddVisitor(Visitor visitor)
        {
            try
            {
                return VisitorsDAL.AddVisitor(visitor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  int UpdateVisiter(Visitor visitor)
        {
            try
            {
                return VisitorsDAL.UpdateVisiter(visitor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  int DeleteVisiter(int id)
        {
            try
            {
                return VisitorsDAL.DeleteVisiter(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
