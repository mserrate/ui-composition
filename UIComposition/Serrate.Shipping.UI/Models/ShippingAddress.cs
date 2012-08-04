using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serrate.Shipping.UI.Models
{
    public class ShippingAddress
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
