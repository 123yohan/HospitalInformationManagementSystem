using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Models
{
    public class staff
    {
        public int StaffId { get; set; }
        public string StaffType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string Nic { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string UserRoleName { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
