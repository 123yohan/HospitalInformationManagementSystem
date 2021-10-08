using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
    public class PostalDAL
    {
        private static readonly UOVT_HIMSEntities _Con = new UOVT_HIMSEntities();

        public static List<Postal> GetAllPostals()
        {
            try
            {
                return _Con.Postals.Where(x => x.IsDelete == false).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Postal> GetPostalsById(int id)
        {
            try
            {
                return _Con.Postals.Where(x=>x.Id  == id && x.IsDelete == false).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int AddPostal(Postal postal)
        {
            try
            {
                _Con.Postals.Add(postal);
               return _Con.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async static Task<int> UpdatePostal(Postal postal)
        {
            try
            {
                var res = _Con.Postals.Find(postal.Id);

                if(res != null)
                {
                    res.ReferenceNo = postal.ReferenceNo;
                    res.IsReceivedMail = postal.IsReceivedMail;
                    res.FromAddress = postal.FromAddress;
                    res.ToAddress = postal.ToAddress;
                    res.FromName = postal.FromName;
                    res.ToName = postal.ToName;
                    res.Note = postal.Note;
                    
                    return await _Con.SaveChangesAsync();
                }

                return 0;
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int DeletePostal(int Id)
        {
            try
            {
                var res = _Con.Postals.Find(Id);

                if (res != null)
                {
                    res.IsDelete = true;
                    return _Con.SaveChanges();
                }

                return 0;

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
