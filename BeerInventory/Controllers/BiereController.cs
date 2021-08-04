using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerInventory.Controllers
{
    public class BiereController : Controller
    {
        // GET: Biere
        public ActionResult Index()
        {
            return View();
        }
    }
}