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
    public partial class PatientDetailsPL : Form
    {
        public PatientDetailsPL()
        {
            InitializeComponent();
        }

        private void btnAddPaitent_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PatientAddPL))
                {
                    f.Activate();
                    return;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(PatientAddPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new PatientAddPL();
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
