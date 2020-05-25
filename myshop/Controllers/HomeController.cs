using myshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myshop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ProdContext db = new ProdContext();
        public ActionResult Index()
        {
            return View(db.prod);
        }


    }

}