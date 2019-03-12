using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class BookInfoDAL
    {
        /// <summary>
        /// Find and by BkID/BkName/TypeID Find
        /// </summary>
        /// <param name="bkFilter">Model_BookIngo_View</param>
        /// <returns>List</returns>
        public static List<BookInfo_View> Find(BookInfo_View bkFilter)
        {
            try
            {
                using (BookDB_Model BkDB = new BookDB_Model())
                {
                    var list = from data in BkDB.BookInfo_View
                               select data;
                    if (bkFilter.BkId > 0)
                        list = list.Where(data => data.BkId == bkFilter.BkId).Select(data => data);
                    if (!string.IsNullOrEmpty(bkFilter.BkName))
                        list = list.Where(data => data.BkName.Contains(bkFilter.BkName)).Select(data => data);
                    if (bkFilter.TypeId > 0)
                        list = list.Where(data => data.TypeId == bkFilter.TypeId).Select(data => data);
                    return list.ToList();
                }
            }
            catch (Exception error)
            {

                throw error;
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>int</returns>
        public static int Del(int id)
        {
            try
            {
                using (BookDB_Model BkDB = new BookDB_Model())
                {
                    BkDB.BookInfo.Remove(BkDB.BookInfo.Find(id));
                    return BkDB.SaveChanges();
                }
            }
            catch (Exception error)
            {

                throw error;
            }
        }

        /// <summary>
        /// Edit
        /// </summary>
        /// <param name="bk">Class</param>
        /// <returns>int</returns>
        public static int Edit(BookInfo bk)
        {
            try
            {
                using (BookDB_Model BkDB = new BookDB_Model())
                {
                    BkDB.Entry(bk).State = System.Data.Entity.EntityState.Modified;
                    return BkDB.SaveChanges();
                }
            }
            catch (Exception error)
            {

                throw error;
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="bk">Class</param>
        /// <returns>int</returns>
        public static int Add(BookInfo bk)
        {
            try
            {
                using (BookDB_Model BkDB = new BookDB_Model())
                {
                    BkDB.BookInfo.Add(bk);
                    return BkDB.SaveChanges();
                }
            }
            catch (Exception error)
            {

                throw error;
            }
        }
    }
}
