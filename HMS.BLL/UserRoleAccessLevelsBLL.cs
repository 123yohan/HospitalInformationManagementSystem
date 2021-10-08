using HMS.DAL;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.BLL
{
    public class UserRoleAccessLevelsBLL
    {
        public ComboBox GetUserRoles(ComboBox cmb)
        {
            try
            {
                cmb.DataSource = UserRoleAccessLevelsDAL.GetUserRoles();
                cmb.ValueMember = "RoleId";
                cmb.DisplayMember = "Name";
                return cmb;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TreeView GetPages(TreeView treeView)
        {
            try
            {
                var res = UserRoleAccessLevelsDAL.GetPages();
                int i = 0;
                foreach(var item in res)
                {
                    treeView.Nodes.Add(item.Name);
                    treeView.Nodes[i].Nodes.Add("Read");
                    treeView.Nodes[i].Nodes.Add("Add");
                    treeView.Nodes[i].Nodes.Add("Edit");
                    treeView.Nodes[i].Nodes.Add("Delete");

                    i++;
                }
                return treeView;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public  void DeleteUserRole(int UserRoleId)
        {
            UserRoleAccessLevelsDAL.DeleteUserRole(UserRoleId);
        }

        public int AddUserRoleAccessLevels(UserRoleAccessLevel userRoleAccessLevel)
        {
            try
            {
                return UserRoleAccessLevelsDAL.AddUserRoleAccessLevels(userRoleAccessLevel);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
