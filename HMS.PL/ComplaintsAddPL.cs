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
        int ComplainId;
        Func<int> DataLoadMethod;
        string fileContent = string.Empty;
        public ComplaintsAddPL(bool Action, Func<int> DataLoadMethod, int Id)
        {
            InitializeComponent();
            complainBLL = new ComplainBLL();

            this.DataLoadMethod = DataLoadMethod;

            if (Action)
            {
                txtAction.ReadOnly = true;
            }
            else
            {
                txtAction.ReadOnly = false;
            }

            if (Id > 0)
            {
                ComplainId = Id;
                btnSubmit.Text = "UPDATE";
                btnClear.Visible = false;
                GetAllComplaintsById(Id);
            }
        }

        public void GetAllComplaintsById(int Id)
        {
            var res = complainBLL.GetComplaints(Id).FirstOrDefault();
            if (res != null)
            {
                txtDescription.Text = res.Complaint;
                txtAction.Text = res.Action;
                txtMobileNo.Text = res.MobileNo;
                cmbType.Text = res.Type;
            }
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

       
    

     

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (staffId <= 0)
            //{
            //    MessageBox.Show("Please Select Staff Member", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;

            //}
             if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please Enter Complain Description", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }
            else
            {
                if(btnSubmit.Text == "SUBMIT")
                {
                    var res = new Complaint
                    {

                        MobileNo = txtMobileNo.Text,
                        Decription = txtDescription.Text.Trim(),
                        Status = 1,
                        CreatedBy = HMSComman.UserAccId,
                        CreatedDate = DateTime.Now,
                        Date = DateTime.Now,
                        Type = cmbType.SelectedItem.ToString(),
                        AttachFiles = fileContent
                    };

                    if (await complainBLL.AddComplain(res) > 0)
                    {
                        MessageBox.Show("Succesfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataLoadMethod();
                        Clear();
                    }
                }
                else
                {
                    var res = new Complaint
                    {
                        ComplainId = ComplainId,
                        MobileNo = txtMobileNo.Text,
                        Decription = txtDescription.Text.Trim(),
                        Status = 1,
                        CreatedBy = HMSComman.UserAccId,
                        CreatedDate = DateTime.Now,
                        Date = DateTime.Now,
                        Type = cmbType.SelectedItem.ToString(),
                        Action = txtAction.Text,
                        AttachFiles = fileContent
                    };

                    if (await complainBLL.UpdateComplain(res) > 0)
                    {
                        MessageBox.Show("Succesfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataLoadMethod();
                        this.Close();
                        Clear();
                    }
                }

              
            }
        }

        public void Clear()
        {
            txtDescription.Text = "";
            txtMobileNo.Text = "";
            txtAction.ReadOnly = true;
            cmbType.SelectedIndex = -1;
            btnSubmit.Text = "SUBMIT";
            ComplainId = 0;
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

        private void ComplaintsAddPL_Load(object sender, EventArgs e)
        {

        }
    }
}
