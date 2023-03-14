using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Models.CustomerOrderModels
{
    public class CustomerOrderDetail
    {
        public int CustomerOrderId {get; set;}
        public int CustomerId {get; set;}
        public int VehicleId {get; set;}
        public Decimal LaborPrice {get; set;}
        public Decimal TotalPrice {get; set;}
    }
}