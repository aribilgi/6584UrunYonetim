using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        Repository<Category> repositoryCategory = new Repository<Category>();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialMenu()
        {
            return PartialView(repositoryCategory.GetAll(c => c.IsActive));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}