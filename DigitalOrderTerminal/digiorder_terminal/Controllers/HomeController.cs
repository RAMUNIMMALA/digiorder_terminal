using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digiorder_terminal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //load Category/Most Popular menu/Today Offers/Favorite
            return View();
        }

    }
}