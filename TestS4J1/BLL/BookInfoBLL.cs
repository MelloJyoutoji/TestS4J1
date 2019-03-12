using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class BookInfoBLL
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
                return BookInfoDAL.Find(bkFilter);
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
                return BookInfoDAL.Del(id);
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
                return BookInfoDAL.Edit(bk);
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
                return BookInfoDAL.Add(bk);
            }
            catch (Exception error)
            {

                throw error;
            }
        }
    }
}
