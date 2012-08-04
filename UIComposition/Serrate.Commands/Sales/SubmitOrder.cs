using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serrate.Infrastructure;

namespace Serrate.Commands.Sales
{
    public class SubmitOrder : ICommand
    {
        public Guid OrderId { get; set; }
    }
}
