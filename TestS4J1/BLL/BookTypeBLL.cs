using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class BookTypeBLL
    {
        /// <summary>
        /// Find
        /// </summary>
        /// <returns>list</returns>
        public static List<BookType> Find()
        {
            try
            {
                return BookTypeDAL.Find();
            }
            catch (Exception error)
            {

                throw error;
            }
        }
    }
}
