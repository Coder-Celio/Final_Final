using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Services.VehicleServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustInfo.MVC.Controllers
{
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        
        private IVehicleService _VehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            _VehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _VehicleService.GetVehicleLists());
        }
    }
}