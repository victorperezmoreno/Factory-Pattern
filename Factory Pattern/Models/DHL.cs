using Factory_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Pattern.Models
{
    public class DHL: IShippingCourier
    {
        public string GenerateConsignmentLabelFor(Address address)
        {
            return "DHL-XXXX-XXXX-XXXX";
        }
    }
}
