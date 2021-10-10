using HMS.BLL;
using HMS.DAL;
using HMS.Entity.Models;
using HMS.Models;
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
    public partial class AppoitmentPL : Form
    {
        AppoitmentBLL appoitmentBLL;
        PatientBLL patientBLL;
        AppointmentReportBLL appointmentReportBLL;
        int staffId, patientId, AppoitmentId;
        Func<int> DataLoadMethod;
        public AppoitmentPL(Func<int> DataLoadMethod,  int AppoimentId)
        {
            InitializeComponent();
            appoitmentBLL = new AppoitmentBLL();
            appointmentReportBLL = new AppointmentReportBLL();
            this.DataLoadMethod = DataLoadMethod;
            patientBLL = new PatientBLL();
            PageAccess();
            if (AppoimentId > 0)
            {
                btnSubmit.Text = "UPDATE";
                btnClear.Visible = false;
                GetAllAppoiments(AppoimentId);
            }

        }

        public void PageAccess()
        {
            var res = LoginDAL.lstUserRole.Where(x => x.PageName == "Patient").FirstOrDefault();
            if (res != null)
            {
                if (res.AddCommand == true)
                {
                    btnAddPaitent.Visible = true;
                }

               
            }


        }

        public void GetAllAppoiments(int AppoimentId)
        {
           var app = appointmentReportBLL.GetAllAppointments(AppoimentId).FirstOrDefault();
            txtPatient.Text = app.PatientName;
            txtMedical.Text = app.StaffName;
            dtpAppoinmentTime.Text = app.Time.ToString();
            dtpAppointmentDate.Text = app.Date.ToString();
            staffId = app.PatientId;
            patientId = app.PatientId;
            AppoitmentId = app.AppoitmentId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Form frm = new PatientAddPL(LoadDataDgvStaff,0);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        public int LoadDataDgvStaff()
        {
            
            return 0;
        }

        private void txtMedical_TextChanged(object sender, EventArgs e)
        {
            var res = appoitmentBLL.GetStaff(lstViewStaff, txtMedical.Text);

            if (res.Items.Count > 0)
                lstViewStaff.Visible = true;
            else
                lstViewStaff.Visible = false;

            if (txtMedical.Text.Length <= 0)
            {
                lstViewStaff.Visible = false;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (staffId <= 0)
            {
                MessageBox.Show("Please Select Medical Officer", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedical.Focus();
                return;
            }

            if (btnSubmit.Text == "SUBMIT")
            {
                var app = new Appointment
                {
                    PatientId = patientId,
                    CreatedBy = HMSComman.UserAccId,
                    Active = true,
                    IsApproved = false,
                    IsCompleted = false,
                    Time = dtpAppoinmentTime.Value,
                    Date = dtpAppointmentDate.Value,
                    CreatedDate = DateTime.Now,

                };

                if (await appoitmentBLL.AddAppointment(app, staffId) > 0)
                {
                    MessageBox.Show("Succesfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    DataLoadMethod();
                }
            }
            else
            {
                var app = new appointment
                {
                    PatientId = patientId,
                    Time = dtpAppoinmentTime.Value,
                    Date = dtpAppointmentDate.Value,
                    StaffId = staffId,
                    AppoitmentId = AppoitmentId
                };

                if (await appoitmentBLL.UpdateAppointment(app) > 0)
                {
                    MessageBox.Show("Succesfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataLoadMethod();
                    this.Close();
                    Clear();
                }
            }
           


        }

        public void Clear()
        {
            txtMedical.Text = "";
            txtPatient.Text = "";
            dtpAppointmentDate.Value = DateTime.Today;
            dtpAppoinmentTime.Value = DateTime.Now;
            staffId = 0;
            patientId = 0;
            AppoitmentId = 0;
        }

     
        private void lstViewStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lstViewStaff.Items[0].Selected == true)
                {
                    txtMedical.Focus();

                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                staffId = Convert.ToInt32(lstViewStaff.SelectedItems[0].SubItems[0].Text);
                txtMedical.Text = lstViewStaff.SelectedItems[0].SubItems[1].Text;
                lstViewStaff.Items.Clear();
                lstViewStaff.Visible = false;

            }
            if (e.KeyCode == Keys.Escape)
            {
                lstViewStaff.Hide();
                txtMedical.Text = "";
                txtMedical.Focus();

            }
        }

        private void txtPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lstPatient.Items.Count > 0)
                {
                    lstPatient.Focus();
                    lstPatient.Items[0].Selected = true;

                }
            }
        }

        private void txtMedical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lstViewStaff.Items.Count > 0)
                {
                    lstViewStaff.Focus();
                    lstViewStaff.Items[0].Selected = true;

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AppoitmentPL_Load(object sender, EventArgs e)
        {

        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            var res = appoitmentBLL.GetPatients(lstPatient, txtPatient.Text);
            if (res.Items.Count > 0)
                lstPatient.Visible = true;
            else
                lstPatient.Visible = false;

            if (txtPatient.Text.Length <= 0)
            {
                lstPatient.Visible = false;
            }
        }

        private void lstPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lstPatient.Items[0].Selected == true)
                {
                    txtPatient.Focus();

                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                patientId = Convert.ToInt32(lstPatient.SelectedItems[0].SubItems[0].Text);
                txtPatient.Text = lstPatient.SelectedItems[0].SubItems[1].Text;
                lstPatient.Items.Clear();
                lstPatient.Visible = false;

            }
            if (e.KeyCode == Keys.Escape)
            {
                lstPatient.Hide();
                txtPatient.Text = "";
                txtPatient.Focus();

            }
        }
    }
}
