using HMS.Entity.Models;
using HMS.Other;
using Scrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HMS.DAL
{
   public class LoginDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();

       public static ObservableCollection<UserRoleAccessLevel> lstUserRole = new ObservableCollection<UserRoleAccessLevel>();

        public static int Login(UserAccount userAccount)
        {
            var res = _Con.UserAccounts.FirstOrDefault(x => x.Username == userAccount.Username && x.Active == true);
            if(res == null)
            {
                return -1;
            }
            else
            {
                ScryptEncoder encoder = new ScryptEncoder();
                bool isPassword = encoder.Compare(userAccount.Password, res.Password);
                if (isPassword)
                {
                    HMSComman.UserAccId = res.UserId;
                    GetPageAccess(res.UserRoleId);
                    GetUserRoleName(res.UserRoleId);
                    return 1;
                }
                else
                {
                    return -2;
                }
            }
        }

        public static ObservableCollection<UserRoleAccessLevel> GetPageAccess(int? UserRoleId)
        {
          var res = _Con.UserRoleAccessLevels.Where(x => x.UserRoleId == UserRoleId).ToList();
            foreach(var item in res)
            {
                var userrole = new UserRoleAccessLevel
                {
                    PageName = item.PageName,
                    AddCommand = item.AddCommand,
                    EditCommand = item.EditCommand,
                    DeleteCommand = item.DeleteCommand,
                    ReadCommand = item.ReadCommand
                };

                lstUserRole.Add(userrole);
            }

            return lstUserRole;
        }

        public static void GetUserRoleName(int? UserRoleId)
        {
            var res = _Con.UserRoles.FirstOrDefault(x => x.RoleId == UserRoleId);
            if(res != null)
            {
                HMSComman.UserRoleName =  res.Name;
            }
            
        }
    }
}
