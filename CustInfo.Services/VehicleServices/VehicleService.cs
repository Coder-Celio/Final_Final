using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustInfo.Data.Context;
using CustInfo.Data.Entities;
using CustInfo.Models.VehicleModels;
using Microsoft.EntityFrameworkCore;

namespace CustInfo.Services.VehicleServices
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public VehicleService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateVehicle(VehicleCreate model)
        {
            var VehicleCreate = new VehicleEntity
            {
                VehicleId = model.VehicleId,
                Year = model.Year,
                Make = model.Make,
                Model = model.Model
            };
            await _context.Vehicles.AddAsync(VehicleCreate);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteVehicle(int VehicleId)
        {
            var VehicleEntity = await _context.Vehicles.FindAsync(VehicleId);
            if (VehicleEntity != null){
                _context.Vehicles.Remove(VehicleEntity);
                await _context.SaveChangesAsync();
                return true;
            }
             else{
                return false;
            }
        }

        public async Task<bool> EditVehicle(VehicleEdit model)
        {
            var VehicleEdit = await _context.Vehicles.FindAsync(model.VehicleId);
            
            if(VehicleEdit is null)
                return false;
            
            VehicleEdit.VehicleId = model.VehicleId;
            VehicleEdit.Year = model.Year;
            VehicleEdit.Make = model.Make;
            VehicleEdit.Model = model.Model;

            return await _context.SaveChangesAsync() >0;
        }

        public async Task<VehicleDetail> GetVehicleDetailById(int VehicleId)
        {
            var VehicleDetail = await _context.Vehicles.FindAsync(VehicleId);
            if(VehicleDetail == null)
            return default;

            return new VehicleDetail{
                Year = VehicleDetail.Year,
                Make = VehicleDetail.Make,
                Model =VehicleDetail.Model
            };
        }

        public async Task<List<VehicleList>> GetVehicleLists()
        {
            var conversion = await _context.Vehicles.ToListAsync();
            return _mapper.Map<List<VehicleList>>(conversion);
        }
    }
}