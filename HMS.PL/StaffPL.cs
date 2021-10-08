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
    public partial class StaffPL : Form
    {
        StaffBLL staffBLL;
        Func<int> DataLoadMethod;
        int StaffId;
        public StaffPL(Func<int> DataLoadMethod, int Id)
        {
            InitializeComponent();
            staffBLL = new StaffBLL();
            staffBLL.GetUserGroup(cmbUserRole);
            cmbUserRole.SelectedIndex = -1;

            this.DataLoadMethod = DataLoadMethod;

            if (Id > 0)
            {
                StaffId = Id;
                btnSubmit.Text = "UPDATE";
                btnClear.Visible = false;
                GetAllStaffById(Id);
            }
        }

        public void GetAllStaffById(int Id)
        {
          var res =  staffBLL.GetStaffsById(Id).FirstOrDefault();
            if(res != null)
            {
                txtFirstName.Text = res.FirstName;
                txtLastName.Text = res.LastName;
                txtAddress.Text = res.Address;
                txtMobileNo.Text = res.MobileNo;
                txtEmail.Text = res.Email;
                txtNic.Text = res.Nic;
                txtUserName.Text = res.UserName;
                cmbGender.SelectedItem = res.Gender;
                cmbUserRole.Text = res.UserRoleName;
                cmbUserType.SelectedItem = res.StaffType;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter First Name", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Address", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please Enter Email", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else if(cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Gender", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(cmbUserType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select User Type", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(cmbUserRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select User Role", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please Enter User Name", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Password", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(txtConPassword.Text))
            {
                MessageBox.Show("Please Enter Confirm Password", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConPassword.Focus();
                return;
            }
            else if(txtPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("Password Dost not Mach", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                if(btnSubmit.Text == "SUBMIT")
                {
                    if (AddStaff() == 99)
                    {
                        MessageBox.Show("Nic or Email Already Exist", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Succesfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        DataLoadMethod();
                    }
                }
                else
                {
                    if (UpdateStaff() == 99)
                    {
                        MessageBox.Show("Nic or Email Already Exist", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Succesfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        DataLoadMethod();
                    }
                }

                
            }

           
        }

        public int AddStaff()
        {
            var res = new Staff
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Nic = txtNic.Text,
                MobileNo = txtMobileNo.Text,
                Email = txtEmail.Text,
                Gender = cmbGender.Text,
               
                StaffType = cmbUserType.Text,
                CreatedBy = HMSComman.UserAccId,
                CreatedDateTime = DateTime.Now,
                Active = true

            };

            var userAccount = new UserAccount
            {
                Username = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Status = "Staff",
                CreatedDate = DateTime.Now,
                Active = true,
                UserRoleId = Convert.ToInt32(cmbUserRole.SelectedValue.ToString()),
            };

           return staffBLL.AddStaff(res, userAccount);
        }


        public int UpdateStaff()
        {
            var res = new Staff
            {
                StaffId = StaffId,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Nic = txtNic.Text,
                MobileNo = txtMobileNo.Text,
                Email = txtEmail.Text,
                Gender = cmbGender.Text,
               
                StaffType = cmbUserType.Text,
                CreatedBy = HMSComman.UserAccId,
                CreatedDateTime = DateTime.Now,
                
                Active = true

            };

            var userAccount = new UserAccount
            {
                Username = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Status = "Staff",
                CreatedDate = DateTime.Now,
                Active = true,
                 UserRoleId = Convert.ToInt32(cmbUserRole.SelectedValue.ToString()),
            };

            return staffBLL.UpdateStaff(res, userAccount);
        }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobileNo.Text = "";
            txtNic.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtConPassword.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbUserRole.SelectedIndex = -1;
            cmbUserType.SelectedIndex = -1;
            btnSubmit.Text = "SUBMIT";
        }
    }
}
