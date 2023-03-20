using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustInfo.Data.Context;
using CustInfo.Data.Entities;
using CustInfo.Models.CustomerOrderModels;
using Microsoft.EntityFrameworkCore;

namespace CustInfo.Services.CustomerOrderServices
{
    public class CustomerOrderService : ICustomerOrderService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CustomerOrderService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCustomerOrderAsync(CustomerOrderCreate model)
        {
            var customerOrderAsync= new CustomerOrderEntity{
                CustomerOrderId = model.CustomerOrderId,
                CustomerId = model.CustomerId,
                VehicleId = model.VehicleId,
            };
            await _context.CustomerOrders.AddAsync(customerOrderAsync);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCustomerOrder(int id)
        {
            var customerOrderAsync = await _context.CustomerOrders.FindAsync(id);
            if (customerOrderAsync != null)
            {
                _context.CustomerOrders.Remove(customerOrderAsync);
                await _context.SaveChangesAsync();
                return true;
            }
            else{
                return false;
            }
        }

        public async Task<bool> EditCustomerOrderAsync(CustomerOrderEdit model)
        {
            var customerOrderAsync = await _context.CustomerOrders.FindAsync(model.CustomerOrderId);

            if (customerOrderAsync is null)
                return false;

            customerOrderAsync.CustomerOrderId = model.CustomerOrderId;
            customerOrderAsync.CustomerId = model.CustomerId;
            customerOrderAsync.VehicleId = model.VehicleId;
            return await _context.SaveChangesAsync() >0;
        }
         

        public async Task<CustomerOrderDetail> GetCustomerOrderDetailByIdAsync(int OrderId)
        {
            var customerOrderAsync = await _context.CustomerOrders.FindAsync(OrderId);

            if(customerOrderAsync == null)
            return default;

            return new CustomerOrderDetail{
                CustomerOrderId = customerOrderAsync.CustomerOrderId,
                CustomerId = customerOrderAsync.CustomerId,
                VehicleId = customerOrderAsync.VehicleId
            };
            
        }

        public async Task<List<CustomerOrderListItem>> GetCustomerOrdersAsync()
        {
            var conversion = await _context.CustomerOrders.ToListAsync();
            return _mapper.Map<List<CustomerOrderListItem>>(conversion);
        }
    }
}