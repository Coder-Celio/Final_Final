using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustInfo.Data.Context;
using CustInfo.Data.Entities;
using CustInfo.Models.CustomerModels;
using Microsoft.EntityFrameworkCore;

namespace CustInfo.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CustomerService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCustomer(CustomerCreate model)
        {
            var CustomerCreate = new CustomerEntity
            {
                CustomerId = model.CustomerId,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            await _context.Customers.AddAsync(CustomerCreate);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCustomer(int CustomerId)
        {
            var CustomerEntity = await _context.Customers.FindAsync(CustomerId);
            if (CustomerEntity != null){
                _context.Customers.Remove(CustomerEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            else{
                return false;
            }
        }

        public async Task<bool> EditCustomer(CustomerEdit model)
        {
            var CustomerEdit = await _context.Customers.FindAsync(model.CustomerId);

            if (CustomerEdit is null)
                return false;
            
            CustomerEdit.CustomerId = model.CustomerId;
            CustomerEdit.FirstName = model.FirstName;
            CustomerEdit.LastName = model.LastName;

            return await _context.SaveChangesAsync() >0;
        }

        public async Task<CustomerDetail> GetCustomerDetailById(int CustomerId)
        {
            var CustomerDetail = await _context.Customers.FindAsync(CustomerId);
            if(CustomerDetail ==null)
            return default;

            return new CustomerDetail{
                CustomerId = CustomerDetail.CustomerId,
                FirstName = CustomerDetail.FirstName,
                LastName = CustomerDetail.LastName
            };
        }

        public async Task<List<CustomerList>> GetCustomers()
        {
            var conversion = await _context.Customers.ToListAsync();
            return _mapper.Map<List<CustomerList>>(conversion);
        }
        
    }
}