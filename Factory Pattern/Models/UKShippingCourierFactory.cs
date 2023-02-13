using Factory_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Pattern.Models
{
    public class UKShippingCourierFactory
    {
        public IShippingCourier CreateShippingCourier(Order order)
        {
            if ((order.TotalCost > 100) || (order.WeightInKg > 5))
            {
                return new DHL();
            }
            else
            {
                return new RoyalMail();
            }
        }
    }
}
