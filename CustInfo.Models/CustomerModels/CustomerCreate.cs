using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Models.CustomerModels
{
    public class CustomerCreate
    {
        [Key]
        public int CustomerId {get; set;}
        [Required]
        public string FirstName {get; set;}=null!;
        [Required]
        public string LastName {get; set;}=null!;
    }
}