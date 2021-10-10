using HMS.Entity.Models;
using HMS.Models;
using HMS.Other;
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

       

        public static List<complaints> GetComplaints()
        {
            return (from c in _Con.Complaints
                     
                    join p in _Con.Patients on c.CreatedBy equals p.PatientId
                    select new complaints
                    {
                        Type = c.Type,
                        ComplainId = c.ComplainId,
                       Decription = c.Decription,
                       Date = c.CreatedDate,
                        PatientName = p.FirstName + " " + p.LastName,
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
                    //join s in _Con.Staffs on c.StaffId equals s.StaffId
                    join p in _Con.Patients on c.CreatedBy equals p.PatientId
                    where(c.ComplainId == PId)
                    select new complaints
                    {
                        ComplainId = c.ComplainId,
                        //StaffId = s.StaffId,
                        PatientName = p.FirstName + " " + p.LastName,
                      //  StaffName = s.FirstName + " " + s.LastName,
                        MobileNo = c.MobileNo,
                        Complaint = c.Decription,
                        Action = c.Action,
                        Type = c.Type,
                        CreatedDate = c.CreatedDate,
                        UpdateDate = c.UpdateDate
                    }).ToList();
        }

        public static async Task<int> AddComplain(Complaint complaint)
        {
            _Con.Complaints.Add(complaint);
            return await _Con.SaveChangesAsync();
        }  
        
     

        public static async Task<int> UpdatedComplain(Complaint complaint)
        {
            var res = _Con.Complaints.Find(complaint.ComplainId);
            if (res != null)
            {
                res.Action = complaint.Action;
                res.Status = complaint.Status;
                res.MobileNo = complaint.MobileNo;
                res.StaffId = HMSComman.UserAccId;
                res.UpdateDate = complaint.UpdateDate;
                res.UpdateBy = HMSComman.UserAccId;
                res.Type = complaint.Type;
            }

            return await _Con.SaveChangesAsync();
        }

        public static int DeleteComplaint(int Id)
        {
            var res = _Con.Complaints.Find(Id);
            if(res != null)
            {
                res.Status = res.Status;
            }

            return _Con.SaveChanges();
        }
    }
}
