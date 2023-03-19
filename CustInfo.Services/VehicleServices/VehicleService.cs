using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Models.VehicleModels;

namespace CustInfo.Services.VehicleServices
{
    public class VehicleService : IVehicleService
    {
        public Task<bool> CreateVehicle(VehicleCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDetail> GetVehicleDetailById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VehicleList>> GetVehicleLists()
        {
            throw new NotImplementedException();
        }
    }
}