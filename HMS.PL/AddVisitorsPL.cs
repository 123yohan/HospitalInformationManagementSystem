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
    public partial class AddVisitorsPL : Form
    {
        Func<int> DataLoadMethod;
        VisitorsBLL visitorsBLL = new VisitorsBLL();
        int VId = 0;
        public AddVisitorsPL(Func<int> DataLoadMethod,int Id)
        {
            InitializeComponent();
            this.DataLoadMethod = DataLoadMethod;

            if (Id > 0)
            {
                btnSubmit.Text = "UPDATE";
                btnClear.Visible = false;
                VId = Id;
                GetVisitors(Id);
            }
        }

        public void GetVisitors(int Id)
        {
          var res =  visitorsBLL.GetVisitors(Id).FirstOrDefault();
            if(res != null)
            {
                txtAddress.Text = res.Address;
                txtMobileNo.Text = res.MobileNo;
                txtNote.Text = res.Note;
                txtPurpose.Text = res.Purpose;
                txtVisiterName.Text = res.Name;
                txtNic.Text = res.Nic;
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVisiterName.Text))
            {
                MessageBox.Show("Please Enter Visitor Name", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVisiterName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Address", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }


            if (string.IsNullOrEmpty(txtNic.Text))
            {
                MessageBox.Show("Please Enter Nic No", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            if(btnSubmit.Text == "SUBMIT")
            {
                if (AddVisitor() > 0)
                {
                    MessageBox.Show("Succesfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataLoadMethod();
                    this.Close();
                }
            }
            else
            {
                if (UpdateVisitor() > 0)
                {
                    MessageBox.Show("Succesfully Update", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataLoadMethod();
                    this.Close();
                }
            }
           

        }

        public int AddVisitor()
        {
            var res = new Visitor
            {
                Name = txtVisiterName.Text,
                Address = txtAddress.Text,
                MobileNo = txtMobileNo.Text,
                Nic = txtNic.Text,
                Purpose = txtPurpose.Text,
                Note = txtNote.Text,
                Active = true,
                CreatedBy = HMSComman.UserAccId,
                Date = DateTime.Now,
                InTime =  dtpIn.Value,
                OutTime = dtpOut.Value
                
            };
          return  visitorsBLL.AddVisitor(res);

        }

        public int UpdateVisitor()
        {
            var res = new Visitor
            {
                Id = VId,
                Name = txtVisiterName.Text,
                Address = txtAddress.Text,
                MobileNo = txtMobileNo.Text,
                Nic = txtNic.Text,
                Purpose = txtPurpose.Text,
                Note = txtNote.Text,
                Active = true,
                CreatedBy = HMSComman.UserAccId,
                Date = DateTime.Now,
                InTime = dtpIn.Value,
                OutTime = dtpOut.Value

            };
            return visitorsBLL.UpdateVisiter(res);

        }

        private void AddVisitorsPL_Load(object sender, EventArgs e)
        {

        }

        private void btnTimeIN_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
