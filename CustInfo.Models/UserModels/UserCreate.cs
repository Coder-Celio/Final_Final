using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Models.UserModels
{
    public class UserCreate
    {
        [Key]
        public int UserId {get; set;}
        [Required]
        public string UserName {get; set;}=null!;
        [Required]
        public string Password {get; set;}=null!;
        public DateTime ProfileCreated {get; set;}
    }
}