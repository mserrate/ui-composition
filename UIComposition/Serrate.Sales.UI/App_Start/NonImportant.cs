using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serrate.Infrastructure;
using Serrate.Commands.Sales;
using System.Web.Mvc;

namespace Serrate.Sales.UI
{
    public class MegaControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            try
            {
                return base.GetControllerInstance(requestContext, controllerType);
            }
            catch
            {
                return Activator.CreateInstance(controllerType, new SuperBus()) as IController;
            }

        }
    }

    public class SuperBus : IBus
    {
        public void Send(ICommand cmd)
        {
            if (cmd is SubmitOrder)
            {
                var handler = new SubmitOrderHandler(this);
                handler.Handle(cmd as SubmitOrder);
            }
            if (cmd is CancelOrder)
            {
                var handler = new CancelOrderHandler(this);
                handler.Handle(cmd as CancelOrder);
            }
        }

        public void Publish(IEvent evt)
        {
            return;
        }
    }
}