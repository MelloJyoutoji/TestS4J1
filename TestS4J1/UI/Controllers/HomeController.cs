using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var list = BookInfoBLL.Find(new BookInfo_View());
            FindSele();
            return View(list);
        }

        // 写下拉框 主页开始的
        private void FindSele(BookInfo_View bk = null)
        {
            if (bk == null)
            {
                var listSele = BookTypeBLL.Find();
                SelectList seleList = new SelectList(listSele, "TypeId", "TypeName");
                ViewBag.seleList = seleList;
            }
            else
            {
                var listSele = BookTypeBLL.Find();
                SelectList seleList = new SelectList(listSele, "TypeId", "TypeName", bk.TypeId);
                ViewBag.seleList = seleList;
            }
        }

        // 条件查询
        [HttpPost]
        public ActionResult FindPostData(FormCollection fc)
        {
            BookInfo_View bkFilter = new BookInfo_View();
            bkFilter.BkName = fc["BookName"].ToString();
            if (fc["seleList"].ToString() != "")
                bkFilter.TypeId = Convert.ToInt32(fc["seleList"]);
            var list = BookInfoBLL.Find(bkFilter);
            FindSele();
            return View("Index", list);
        }

        // 删除方法
        public ActionResult Del(int id)
        {
            BookInfoBLL.Del(id);
            return RedirectToAction("Index");
        }

        // Open Add
        public ActionResult AddPage()
        {
            FindSele();
            return View();
        }

        // 添加
        [HttpPost]
        public ActionResult Add(FormCollection fc)
        {
            BookInfo bk = new BookInfo();
            bk.BkName = fc["BkName"];
            bk.BkPrice = Convert.ToDecimal(fc["BkPrice"]);
            bk.BkDate = Convert.ToDateTime(fc["BkDate"]);
            bk.TypeId = Convert.ToInt32(fc["BkType"]);
            BookInfoBLL.Add(bk);
            return RedirectToAction("Index");
        }

        // Open Edit
        public ActionResult EditPage(int id)
        {
            var bk = BookInfoBLL.Find(new BookInfo_View() { BkId = id })[0];
            FindSele(bk);
            return View(bk);
        }

        // 修改
        [HttpPost]
        public ActionResult Edit(FormCollection fc)
        {
            BookInfo bk = new BookInfo();
            bk.BkId = Convert.ToInt32(fc["BkID"]);
            bk.BkName = fc["BkName"];
            bk.BkPrice = Convert.ToDecimal(fc["BkPrice"]);
            bk.BkDate = Convert.ToDateTime(fc["BkDate"]);
            bk.TypeId = Convert.ToInt32(fc["BkType"]);
            BookInfoBLL.Edit(bk);
            return RedirectToAction("Index");
        }
    }
}