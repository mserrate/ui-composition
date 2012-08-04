using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serrate.Infrastructure;

namespace Serrate.Commands.Sales
{
    public class CancelOrder : ICommand
    {
        public Guid OrderId { get; set; }
    }
}
