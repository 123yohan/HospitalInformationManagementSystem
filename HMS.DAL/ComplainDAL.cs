using HMS.Entity.Models;
using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{

    public class ComplainDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();

        public static List<Staff> GetStaffs(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return _Con.Staffs.ToList();
            }

            var staffCollection = _Con.Staffs as IQueryable<Staff>;

            if (!string.IsNullOrWhiteSpace(Name))
            {
                Name = Name.Trim();
                staffCollection = staffCollection.Where(x => x.FirstName.Contains(Name));
            }

            return staffCollection.ToList();

        }

        public static List<complaints> GetComplaints()
        {
            return (from c in _Con.Complaints
                     
                    join p in _Con.Patients on c.CreatedBy equals p.PatientId
                    select new complaints
                    {
                        ComplainId = c.ComplainId,
                       
                        PatientName = p.FirstName + "" + p.LastName,
                      //  StaffName = _Con.Staffs.Where(x=>x.StaffId == c.StaffId && x.Active == true).FirstOrDefault() == null ? " " : .FirstName + "" + s.LastName,
                        MobileNo = c.MobileNo,
                        Complaint = c.Decription,
                        Action = c.Action,
                        CreatedDate = c.CreatedDate,
                        UpdateDate = c.UpdateDate
                    }).ToList();
        }

        public static List<complaints> GetComplaints(int PId)
        {
            return (from c in _Con.Complaints
                    join s in _Con.Staffs on c.StaffId equals s.StaffId
                    join p in _Con.Patients on c.CreatedBy equals p.PatientId
                    where(c.CreatedBy == PId)
                    select new complaints
                    {
                        ComplainId = c.ComplainId,
                        StaffId = s.StaffId,
                        PatientName = p.FirstName + "" + p.LastName,
                        StaffName = s.FirstName + "" + s.LastName,
                        MobileNo = s.MobileNo,
                        Complaint = c.Decription,
                        Action = c.Action,
                        CreatedDate = c.CreatedDate,
                        UpdateDate = c.UpdateDate
                    }).ToList();
        }

        public static async Task<int> AddComplain(Complaint complaint)
        {
            _Con.Complaints.Add(complaint);
            return await _Con.SaveChangesAsync();
        }
    }
}
