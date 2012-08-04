using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serrate.Infrastructure;

namespace Serrate.Contract.Sales
{
    public class OrderSubmitted : IEvent
    {
        public Guid OrderId { get; set; }
    }
}
