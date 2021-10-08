using HMS.BLL;
using HMS.Entity.Models;
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
    public partial class AddPostalPL : Form
    {
        PostalBLL postalBLL;
        int PostalId;
        Func<int> DataLoadMethod;
        public AddPostalPL(Func<int> DataLoadMethod,int Id)
        {
            InitializeComponent();
            postalBLL = new PostalBLL();
            this.DataLoadMethod = DataLoadMethod;

            if (Id > 0)
            {
                PostalId = Id;
                btnSubmit.Text = "UPDATE";
                btnClear.Visible = false;
                GetAllPostById(Id);
            }

        }




        public void GetAllPostById(int Id)
        {
            var res = postalBLL.GetPostalsById(Id).FirstOrDefault();
            if(res != null)
            {
                cmbMailType.SelectedIndex = res.IsReceivedMail == true ? 0 : 1;
                txtDesc.Text = res.Note;
                txtFromAddress.Text = res.FromAddress;
                txtFromName.Text = res.FromName;
                txtRefNo.Text = res.ReferenceNo;
                txtToAddress.Text = res.ToAddress;
                txtToName.Text = res.ToName;
               
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbMailType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Mail Type", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMailType.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtRefNo.Text))
                {
                    MessageBox.Show("Please Enter Reference No", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRefNo.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtToAddress.Text))
                {
                    MessageBox.Show("Please Enter To Address", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtToAddress.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtFromAddress.Text))
                {
                    MessageBox.Show("Please Enter From Address", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFromAddress.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtToName.Text))
                {
                    MessageBox.Show("Please Enter To Name", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtToName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtFromName.Text))
                {
                    MessageBox.Show("Please Enter From Name", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFromName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtDesc.Text))
                {
                    MessageBox.Show("Please Enter Description Name", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesc.Focus();
                    return;
                }

                if(btnSubmit.Text == "SUBMIT")
                {
                    var res = new Postal
                    {
                        
                        IsReceivedMail = cmbMailType.SelectedIndex == 0 ? true : false,
                        ReferenceNo = txtRefNo.Text,
                        ToName = txtToName.Text,
                        ToAddress = txtToAddress.Text,
                        FromAddress = txtFromAddress.Text,
                        FromName = txtFromName.Text,
                        Note = txtDesc.Text,
                        CreatedDate = DateTime.Now,
                        IsDelete = false,
                        

                    };

                    if (postalBLL.AddPostal(res) > 0)
                    {
                        MessageBox.Show("Succesfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataLoadMethod();
                        Clear();
                    }
                }
                else
                {
                    var res = new Postal
                    {
                        Id = PostalId,
                        IsReceivedMail = cmbMailType.SelectedIndex == 0 ? true : false,
                        ReferenceNo = txtRefNo.Text,
                        ToName = txtToName.Text,
                        ToAddress = txtToAddress.Text,
                        FromAddress = txtFromAddress.Text,
                        FromName = txtFromName.Text,
                        Note = txtDesc.Text,
                        CreatedDate = DateTime.Now,
                        IsDelete = false,


                    };

                    if ( await postalBLL.UpdatePostal(res) > 0)
                    {
                        MessageBox.Show("Succesfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataLoadMethod();
                        this.Close();
                        Clear();
                    }
                }

              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            txtRefNo.Text = "";
            txtToName.Text = "";
            txtToAddress.Text = "";
            txtFromAddress.Text = "";
            txtFromName.Text = "";
            txtDesc.Text = "";
            cmbMailType.SelectedIndex = -1;
            btnSubmit.Text = "SUBMIT";
            PostalId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
