using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Models.CustomerModels
{
    public class CustomerEdit
    {
        public int CustomerId {get; set;}
        public string FirstName {get; set;}=null!;
        
        public string LastName {get; set;}=null!;
    }
}