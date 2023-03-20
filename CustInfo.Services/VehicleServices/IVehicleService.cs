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
        Task<VehicleDetail> GetVehicleDetailById(int VehicleId);
        Task<bool> EditVehicle(VehicleEdit model);
        Task<bool> DeleteVehicle (int VehicleId); 
    }
}