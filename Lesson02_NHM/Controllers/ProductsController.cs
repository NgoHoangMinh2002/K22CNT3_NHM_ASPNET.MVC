using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_NHM.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:port/Products
        public ActionResult Index()
        {
            ViewBag.name = "Ngo Minh - 2210900044";
            return View();
        }
        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }
        public string Getname()
        {
            return "Ngo Hoang Minh - 2210900044";
        }
        public JsonResult listname()
        {
            string[] name = { "Minh", "Long", "Nam", "KHACDUY" };

            return Json(name, JsonRequestBehavior.AllowGet);
        }
    }
}