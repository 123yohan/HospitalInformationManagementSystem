using HMS.BLL;
using HMS.Entity.Models;
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
        int staffId, patientId;
        public AppoitmentPL()
        {
            InitializeComponent();
            appoitmentBLL = new AppoitmentBLL();
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
            Form frm = new PatientAddPL();
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
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

            var app = new Appointment
            {
                PatientId = patientId,
                CreatedBy = HMSComman.UserAccId,
                Active = true,
                Time =dtpAppoinmentTime.Value,
                Date = dtpAppointmentDate.Value,
                CreatedDate = DateTime.Now,

            };

            if( await appoitmentBLL.AddAppointment(app, staffId) > 0)
            {
                MessageBox.Show("Succesfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }


        }

        public void Clear()
        {
            txtMedical.Text = "";
            txtPatient.Text = "";
            dtpAppointmentDate.Value = DateTime.Today;
            dtpAppoinmentTime.Value = DateTime.Now;

        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            var res = appoitmentBLL.GetPatients(lstPatient, txtPatient.Text);

            if (res.Items.Count > 0)
                lstPatient.Visible = true;
            else
                lstPatient.Visible = false;

            if (txtMedical.Text.Length <= 0)
            {
                lstPatient.Visible = false;
            }
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
