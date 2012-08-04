using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Serrate.Shipping.UI.Models;

namespace Serrate.Shipping.UI.Controllers
{
    public class ShippingOrderController : Controller
    {
        [ChildActionOnly]
        public ActionResult ShippingAddress()
        {
            //get shipping address for the current user
            var shipaddress = new ShippingAddress()
            {
                Id = Guid.NewGuid(),
                Fullname = "John Doe",
                Address = "Pattern St. 23",
                City = "Barcelona"
            };

            return PartialView(shipaddress);
        }
    }
}
