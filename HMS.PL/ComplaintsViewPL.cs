using HMS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.PL
{
    public partial class ComplaintsViewPL : Form
    {
        ComplainBLL complainBLL;
        public ComplaintsViewPL()
        {
            InitializeComponent();
            complainBLL = new ComplainBLL();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddComplains_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AppoitmentPL))
                {
                    f.Activate();
                    return;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(ComplaintsAddPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new ComplaintsAddPL();
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void ComplaintsViewPL_Load(object sender, EventArgs e)
        {
            complainBLL.GetComplaints(dgvComplain);
        }
    }
}
