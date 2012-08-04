using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Serrate.Infrastructure;
using Serrate.Commands.Sales;

namespace Serrate.Sales.UI.Controllers
{
    public class FinishOrderController : Controller
    {
        private readonly IBus bus;

        public FinishOrderController(IBus bus)
        {
            this.bus = bus;
        }

        [ChildActionOnly]
        public ActionResult SubmitOrCancel()
        {
            ViewBag.OrderId = TheSession.OrderId;

            return PartialView();
        }

        
        [HttpPost]
        public ActionResult SubmitOrder()
        {
            var cmd = new SubmitOrder()
            {
                OrderId = TheSession.OrderId
            };

            this.bus.Send(cmd);

            return RedirectToAction("Processed", "Order");
        }

        [HttpPost]
        public ActionResult CancelOrder()
        {
            var cmd = new CancelOrder()
            {
                OrderId = TheSession.OrderId
            };

            this.bus.Send(cmd);

            return RedirectToAction("Cancelled", "Order");
        }
    }
}
