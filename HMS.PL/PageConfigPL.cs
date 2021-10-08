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
    public partial class PageConfigPL : Form
    {
        UserRoleAccessLevelsBLL userRoleAccessLevelsBLL;
        List<UserRoleAccessLevel> lstUserRole = new List<UserRoleAccessLevel>();
        public PageConfigPL()
        {
            InitializeComponent();
            userRoleAccessLevelsBLL = new UserRoleAccessLevelsBLL();

            userRoleAccessLevelsBLL.GetUserRoles(cmbUserRole);
            cmbUserRole.SelectedIndex = -1;

            userRoleAccessLevelsBLL.GetPages(TreeViewPageConfig);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PageConfigPL_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbUserRole.SelectedValue) == 0)
            {
                MessageBox.Show("Please Select User Role", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
              
            userRoleAccessLevelsBLL.DeleteUserRole(Convert.ToInt32(cmbUserRole.SelectedValue));

            foreach (TreeNode node in TreeViewPageConfig.Nodes)
            {
                var res = new UserRoleAccessLevel
                {
                    UserRoleId = Convert.ToInt32(cmbUserRole.SelectedValue),
                    PageName = node.Text,


                };

                foreach (TreeNode pr in node.Nodes)
                {
                    if (pr.Text == "Add") { res.AddCommand = pr.Checked; }
                    else if (pr.Text == "Edit") { res.EditCommand = pr.Checked; }
                    else if (pr.Text == "Delete") { res.DeleteCommand = pr.Checked; }
                    else if (pr.Text == "Read") { res.ReadCommand = pr.Checked; }
                }
                if(res.DeleteCommand==true || res.AddCommand == true || res.EditCommand == true || res.ReadCommand == true )
                userRoleAccessLevelsBLL.AddUserRoleAccessLevels(res);
            }

        }
        bool busy = false;
        private void TreeViewPageConfig_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (busy) return;
            busy = true;
            try
            {
                checkNodes(e.Node, e.Node.Checked);
            }
            finally
            {
                busy = false;
            }
        }


        private void checkNodes(TreeNode node, bool check)
        {





            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = check;
                checkNodes(child, check);



                //foreach (TreeNode a in child.Parent.Nodes)
                //{
                //    var b = new UserRoleAccessLevel
                //    {
                //        UserRoleId = Convert.ToInt32(cmbUserRole.SelectedValue),
                //        PageName = child.Parent.ToString(),
                //        AddCommand = a.Text == "Add" ? true : false,
                //        EditCommand = a.Text == "Edit" ? true : false,
                //        DeleteCommand = a.Text == "Delete" ? true : false,


                //    };
                //}

                //    lstUserRole.Add();


            }
        }
    }
}

