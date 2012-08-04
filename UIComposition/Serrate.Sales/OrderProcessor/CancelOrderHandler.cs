using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serrate.Infrastructure;
using Serrate.Commands.Sales;
using Serrate.Contract.Sales;

namespace Serrate.Sales
{
    public class CancelOrderHandler : IHandle<CancelOrder>
    {
        private readonly IBus bus;

        public CancelOrderHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(CancelOrder msg)
        {
            // do other things

            this.bus.Publish(new OrderCancelled { OrderId = msg.OrderId });
        }
    }
}
