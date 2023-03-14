using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Models.UserModels
{
    public class UserDetail
    {
        public int UserId {get; set;}
        public string UserName {get; set;}=null!;
        public string Password {get; set;}=null!;
        public DateTime ProfileCreated {get; set;}
    }
}