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
    public class ComplainBLL
    {
        public ListView GetStaff(ListView lstStaff, string Name)
        {
            var res = ComplainDAL.GetStaffs(Name);
            lstStaff.Items.Clear();
            foreach(var item in res)
            {
                ListViewItem ListItem = new ListViewItem(item.StaffId.ToString());
                ListItem.SubItems.Add(item.FirstName + " " + item.LastName);
                lstStaff.Items.Add(ListItem);
            }

            return lstStaff;
        }

        public async Task<int> AddComplain(Complaint complaint)
        {
            return await ComplainDAL.AddComplain(complaint);
        }
    }
}
