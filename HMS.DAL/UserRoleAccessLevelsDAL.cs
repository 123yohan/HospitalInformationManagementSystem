using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
    public class UserRoleAccessLevelsDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();
        public static List<UserRole> GetUserRoles()
        {
            try
            {
                return _Con.UserRoles.Where(x => x.Active == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Page> GetPages()
        {
            try
            {
                return _Con.Pages.Where(x => x.Active == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void  DeleteUserRole(int UserRoleId)
        {
            var res = _Con.UserRoleAccessLevels.Where(x => x.UserRoleId == UserRoleId).ToList();
            if (res.Count > 0)
            {
                _Con.UserRoleAccessLevels.RemoveRange(res);
                _Con.SaveChanges();
            }
        }
        public static int AddUserRoleAccessLevels(UserRoleAccessLevel userRoleAccessLevel)
        {
            try
            {
                

                _Con.UserRoleAccessLevels.Add(userRoleAccessLevel);
                return _Con.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
