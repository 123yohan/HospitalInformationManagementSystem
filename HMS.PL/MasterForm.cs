using HMS.DAL;
using HMS.Other;
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
    public partial class MasterForm : Form
    {
        private int childFormNumber = 0;

        public MasterForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.FromArgb(45, 45, 45);
                    // 4#
                    break;
                }
            }
            lblAdmin.Text = HMSComman.UserRoleName;
            CheckPageAccess();


        }

        public void CheckPageAccess()
        {
            foreach(var item in LoginDAL.lstUserRole)
            {
                if(item.PageName == "Staff")
                {
                    button2.Visible = true;
                }
                else if(item.PageName == "Patient")
                {
                    btnPatient.Visible = true;
                }
                else if (item.PageName == "Visitors")
                {
                    btnVisitors.Visible = true;
                }
                else if (item.PageName == "Complatine")
                {
                    btnComplatine.Visible = true;
                }
                else if (item.PageName == "Appointment")
                {
                    bnappointment.Visible = true;
                }
                else if (item.PageName == "Approved Appointment")
                {
                    button3.Visible = true;
                }
                else if (item.PageName == "Appointment Report")
                {
                    btnAppointmentReport.Visible = true;
                }
                else if (item.PageName == "Delelete Appointment")
                {
                    btnDletedAppointment.Visible = true;
                }
                else if (item.PageName == "Page Config")
                {
                    btnPc.Visible = true;
                }
                else if (item.PageName == "User Log Report")
                {
                    btnUserLog.Visible = true;
                }
                else if (item.PageName == "Postal")
                {
                    btnPostal.Visible = true;
                }
            }
           
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_DATE.Text = DateTime.Now.ToShortDateString();
            lbl_time.Text = DateTime.Now.ToShortTimeString();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f.GetType() == typeof(StaffPL))
            //    {
            //        f.Activate();
            //        return;
            //    }
            //}
            //Form frm = new StaffPL();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(StaffDetailsPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new StaffDetailsPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PatientDetailsPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new PatientDetailsPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnComplatine_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ComplaintsViewPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new ComplaintsViewPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PageConfigPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new PageConfigPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bnappointment_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AppointmentViewPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new AppointmentViewPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aDDEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uSERACCOUNTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iNVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oTHERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uSERACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDBRANDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDITEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sTOCKREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sALESREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gRNREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cUSTOMERREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointmentReport_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Appointment_ReportPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new Appointment_ReportPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(UserLoginPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new UserLoginPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ApprovedAppoinmentPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new ApprovedAppoinmentPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDletedAppointment_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(DeleteAppoinmentRecordPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new DeleteAppoinmentRecordPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVisitors_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(VisitorsPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new VisitorsPL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPostal_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PostalViewPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new PostalViewPL();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
