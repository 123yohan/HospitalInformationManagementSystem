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

        public static async Task<int> AddComplain(Complaint complaint)
        {
            _Con.Complaints.Add(complaint);
            return await _Con.SaveChangesAsync();
        }
    }
}
