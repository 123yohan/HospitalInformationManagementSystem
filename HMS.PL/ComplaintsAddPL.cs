using HMS.BLL;
using HMS.Entity.Models;
using HMS.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.PL
{
    public partial class ComplaintsAddPL : Form
    {
        ComplainBLL complainBLL;
        int staffId;
        string fileContent = string.Empty;
        public ComplaintsAddPL()
        {
            InitializeComponent();
            complainBLL = new ComplainBLL();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtstaff_TextChanged(object sender, EventArgs e)
        {

            var res = complainBLL.GetStaff(lstViewStaff, txtstaff.Text);
            if (res.Items.Count > 0)
                lstViewStaff.Visible = true;
            else
                lstViewStaff.Visible = false;

            if (txtstaff.Text.Length <= 0)
            {
                lstViewStaff.Visible = false;
            }
        }

        private void txtstaff_KeyDown(object sender, KeyEventArgs e)
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

        private void lstViewStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lstViewStaff.Items[0].Selected == true)
                {
                    txtstaff.Focus();

                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                staffId = Convert.ToInt32(lstViewStaff.SelectedItems[0].SubItems[0].Text);
                txtstaff.Text = lstViewStaff.SelectedItems[0].SubItems[1].Text;
                lstViewStaff.Items.Clear();
                lstViewStaff.Visible = false;

            }
            if (e.KeyCode == Keys.Escape)
            {
                lstViewStaff.Hide();
                txtstaff.Text = "";
                txtstaff.Focus();

            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (staffId <= 0)
            {
                MessageBox.Show("Please Select Staff Member", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtstaff.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please Enter Complain Description", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }
            else
            {
                var res = new Complaint
                {
                    StaffId = staffId,
                    MobileNo = txtMobileNo.Text,
                    Decription = txtDescription.Text.Trim(),
                    Status = 1,
                    CreatedBy = HMSComman.UserAccId,
                    CreatedDate = DateTime.Now,
                    Date = dtpDate.Value,
                    Type = "",
                    AttachFiles = fileContent
                };

                if (await complainBLL.AddComplain(res) > 0)
                {
                    MessageBox.Show("Succesfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        public void Clear()
        {
            txtDescription.Text = "";
            txtMobileNo.Text = "";
            txtstaff.Text = "";
            dtpDate.Value = DateTime.Now;
            cmbType.SelectedIndex = -1;
        }

        private void btnAttach_Click_1(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAttach.Text = openFileDialog1.FileName;
            }

            //Read the contents of the file into a stream
            var fileStream = openFileDialog1.OpenFile();

            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = reader.ReadToEnd();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
