using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Models
{
    public class appointment
    {
        public int AppoitmentId { get; set; }
        public int PatientId { get; set; }
        public int StaffId { get; set; }
      
        public string PatientName { get; set; }
        public string StaffName { get; set; }
        public string CreatedName { get; set; }
        public DateTime? Time { get; set; }
        public DateTime? Date { get; set; }
        public DateTime CreatedDa { get; set; }
    }
}
