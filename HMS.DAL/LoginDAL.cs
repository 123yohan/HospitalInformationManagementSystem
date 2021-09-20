using HMS.Entity.Models;
using HMS.Other;
using Scrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
   public class LoginDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();

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
                    return 1;
                }
                else
                {
                    return -2;
                }
            }
        }
    }
}
