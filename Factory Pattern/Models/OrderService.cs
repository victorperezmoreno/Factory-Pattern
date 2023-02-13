using Factory_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Pattern.Models
{
    public class OrderService
    {
        public void Dispatch(Order order)
        {
            //This is the class that calls the Factory Pattern
            IShippingCourier shippingCourier = new UKShippingCourierFactory().CreateShippingCourier(order);
            order.CourierTrackingId = shippingCourier.GenerateConsignmentLabelFor(order.DispatchAddress);
        }
    }
}
