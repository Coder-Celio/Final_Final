using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Data.Entities
{
    public class VehicleEntity
    {
        [Key]
        public int VehicleId {get; set;}
        [Required]
        public int Year {get; set;}
        [Required]
        public string Make {get; set;}=null!;
        [Required]
        public string Model {get; set;}=null!;
        public  int CustomerId {get; set;}
        
    }
}