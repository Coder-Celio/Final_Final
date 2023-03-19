using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Models.CustomerModels;

namespace CustInfo.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        public Task<bool> CreateCustomer(CustomerCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDetail> GetCustomerDetailById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerList>> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}