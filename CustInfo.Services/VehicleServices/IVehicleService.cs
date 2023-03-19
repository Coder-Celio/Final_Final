using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Models.VehicleModels;

namespace CustInfo.Services.VehicleServices
{
    public interface IVehicleService
    {
        Task<bool> CreateVehicle (VehicleCreate model);   
        Task<List<VehicleList>> GetVehicleLists();
        Task<VehicleDetail> GetVehicleDetailById(int id);
        Task<bool> EditVehicle(int id); 
    }
}