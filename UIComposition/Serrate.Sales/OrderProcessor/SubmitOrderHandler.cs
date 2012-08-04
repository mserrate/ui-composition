using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serrate.Infrastructure;
using Serrate.Commands.Sales;
using Serrate.Contract.Sales;

namespace Serrate.Sales
{
    public class SubmitOrderHandler : IHandle<SubmitOrder>
    {
        private readonly IBus bus;

        public SubmitOrderHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(SubmitOrder msg)
        {
            //do things..

            bus.Publish(new OrderSubmitted { OrderId = msg.OrderId });
        }
    }
}
