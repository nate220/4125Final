using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Final4125_Morrison.Models;

namespace Final4125_Morrison.Controllers
{
    public class DTController : Controller
    {

        public ActionResult Today()
        {
            
            DateTime time = DateTime.Now;
            String timeNow = time.ToString();
            var name = new Store() {Name = "Time now: " + timeNow};
            return View(name);

        }

        // GET: DT
        public ActionResult Index()
        {
            return View();
        }

    }
}