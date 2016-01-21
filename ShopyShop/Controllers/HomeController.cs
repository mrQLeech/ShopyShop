using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopyShop.Models;

namespace ShopyShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (ProductContext context = new ProductContext())
            {
                LocalUser use = new LocalUser { Login = "sa", Password = "q", BeginDate = DateTime.Now, Version = 1, EndDate = DateTime.Now.AddYears(100) };
            }


            return View();
        }
    }
}
