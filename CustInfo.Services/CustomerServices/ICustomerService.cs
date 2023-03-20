using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Models.CustomerModels;

namespace CustInfo.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<bool>CreateCustomer(CustomerCreate model);
        Task<List<CustomerList>> GetCustomers();
        Task<CustomerDetail> GetCustomerDetailById(int CustomerId);
        Task<bool> EditCustomer(CustomerEdit model);
        Task<bool> DeleteCustomer (int CustomerId);
    }
}