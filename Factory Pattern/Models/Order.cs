using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Pattern.Models
{
    public class Order
    {
        public decimal TotalCost { get; set; }
        public decimal WeightInKg { get; set; }
        public string CourierTrackingId { get; set; }
        public Address DispatchAddress { get; set; }

    }
}
