using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Data.Entities
{
    public class CustomerOrderEntity
    {
        [Key]
        public int CustomerOrderId {get; set;}
        
        public int CustomerId {get; set;}
        
        public int VehicleId {get; set;}
        public Decimal LaborPrice {get; set;}
        public Decimal TotalPrice {get; set;}
    }
}