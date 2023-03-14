using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustInfo.Models.VehicleModels
{
    public class VehicleDetail
    {
        public int Year {get; set;}
        public string Make {get; set;}=null!;
        public string Model {get; set;}=null!;
    }
}