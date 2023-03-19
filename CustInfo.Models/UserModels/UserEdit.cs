using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Models.UserModels
{
    public class UserEdit
    {
         public int UserId {get; set;}
        
        public string UserName {get; set;}=null!;
        
        public string Password {get; set;}=null!;
    }
}