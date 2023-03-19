using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Data.Context;
using CustInfo.Models.CustomerOrderModels;


namespace CustInfo.Services.CustomerOrderServices
{
    public class CustomerOrderService : ICustomerOrderService
    {
        private readonly ApplicationDbContext _context;

        public Task<bool> CreateCustomerOrderAsync(CustomerOrderCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomerOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditCustomerOrderAsync(CustomerOrderEdit model)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerOrderDetail> GetCustomerOrderDetailByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerOrderListItem>> GetCustomerOrdersAsync()
        {
            throw new NotImplementedException();
        }
    }
}