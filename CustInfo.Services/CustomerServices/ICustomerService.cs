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
        Task<CustomerDetail> GetCustomerDetailById(int id);
        Task<bool> DeleteCustomer (int id);
    }
}