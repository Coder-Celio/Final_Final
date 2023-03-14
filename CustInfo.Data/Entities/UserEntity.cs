using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Data.Entities
{
    public class UserEntity
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