using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using digiorder_terminal.Models;

namespace digiorder_terminal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //to disable Home button
            ViewBag.isHome = true;

            //load Category/Most Popular menu/Today Offers/Favorite
            return View();
        }

        public ActionResult Menu(String GUID)
        {
            return View();
        }

        [HttpPost]
        public ActionResult getAddOnsById()
        {
            List<AddOnModel> empList = new List<AddOnModel>()
             {
                 new AddOnModel{ID = 1, Title = "ONION", Price="10.00", Image = "onion.png"},
                 new AddOnModel{ID = 2, Title = "GHEE", Price="5.00", Image = "ghee.png"},
                 new AddOnModel{ID = 3, Title = "KARA", Price="10.00", Image = "kara.png"},
                 new AddOnModel{ID = 4, Title = "UPMA", Price="15.00", Image = "upma.png"}
             };

            return PartialView("Partial/_AddOns", empList);
        }

    }
}