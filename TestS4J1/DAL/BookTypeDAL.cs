using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class BookTypeDAL
    {
        /// <summary>
        /// Find
        /// </summary>
        /// <returns>list</returns>
        public static List<BookType> Find()
        {
            try
            {
                using (BookDB_Model BkDB = new BookDB_Model())
                {
                    var list = from data in BkDB.BookType
                               select data;
                    return list.ToList();
                }
            }
            catch (Exception error)
            {

                throw error;
            }
        }
    }
}
