using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
    public class VisitorsDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();


        public static List<Visitor> GetVisitors()
        {
            return _Con.Visitors.Where(x => x.Active == true).ToList();
        }

        public static int AddVisitor(Visitor visitor)
        {
            try
            {
                _Con.Visitors.Add(visitor);
                return _Con.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int UpdateVisiter(Visitor visitor)
        {
            try
            {
                var vis = _Con.Visitors.Find(visitor.Id);
                if(vis != null)
                {
                    vis.Name = visitor.Name;
                    vis.Address = visitor.Address;
                    vis.Nic = visitor.Nic;
                    vis.InTime = visitor.InTime;
                    vis.OutTime = visitor.OutTime;
                    vis.MobileNo = visitor.MobileNo;
                    vis.Note = visitor.Note;
                    vis.Purpose = visitor.Purpose;
                }

                return _Con.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static int DeleteVisiter(int id)
        {
            try
            {
                var vis = _Con.Visitors.Find(id);
                if (vis != null)
                {
                    vis.Active = false;
                }

                return _Con.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
