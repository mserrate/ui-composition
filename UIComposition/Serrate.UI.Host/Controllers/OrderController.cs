using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Serrate.UI.Host.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult FinalStep()
        {
            return View();
        }

        public ActionResult Processed()
        {
            return View();
        }
        public ActionResult Cancelled()
        {
            return View();
        }
    }
}
