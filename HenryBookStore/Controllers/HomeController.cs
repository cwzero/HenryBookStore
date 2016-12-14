using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HenryBookStore.Models;

namespace HenryBookStore.Controllers
{
    public class HomeController : Controller
    {
        private HenryBookStoreModel db = new HenryBookStoreModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Abount Henry's Bookstore";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Share your Comments with Management";
            ViewBag.db = db;

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            ViewBag.Message = "Thank you for your comments";
            ViewBag.db = db;

            return View(model);
        }

        public ActionResult Inventory()
        {
            return View(db.BOOKs);
        }

        public ActionResult Details(string book_code = "")
        {
            if (book_code != "")
            {
                return View(db.BOOKs.First(b => b.BOOK_CODE == book_code));
            }
            else
            {
                return View();
            }
        }

        public ActionResult Author(int author_num = -1)
        {
            ViewBag.db = db;
            if (author_num >= 0)
            {
                return View(db.AUTHORs.First(a => a.AUTHOR_NUM == author_num));
            }
            else
            {
                return View();
            }
        }

        public ActionResult Publisher(string publisher_code = "")
        {
            ViewBag.db = db;
            if (publisher_code != "")
            {
                return View(db.PUBLISHERs.First(p => p.PUBLISHER_CODE == publisher_code));
            }
            else
            {
                return View();
            }
        }

        public ActionResult Location(int branch_num = -1)
        {
            ViewBag.db = db;
            if (branch_num > 0)
            {
                return View(db.BRANCHes.First(b => b.BRANCH_NUM == branch_num));
            }
            else
            {
                return View();
            }
        }
    }
}