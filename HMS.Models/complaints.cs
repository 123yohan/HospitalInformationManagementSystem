using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Models
{
  public  class complaints
    {
        public int ComplainId { get; set; }
        public int PatientId { get; set; }
        public int StaffId { get; set; }
        public string Status { get; set; }
        public string PatientName { get; set; }
        public string StaffName { get; set; }
        public string Complaint { get; set; }
        public string Action { get; set; }
        public string MobileNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
