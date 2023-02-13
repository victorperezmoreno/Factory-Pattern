using Factory_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Pattern.Interfaces
{
    public interface IShippingCourier
    {
        string GenerateConsignmentLabelFor(Address address);
    }
}
