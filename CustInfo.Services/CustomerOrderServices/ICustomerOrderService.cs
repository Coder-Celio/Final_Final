using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Models.CustomerModels;
using CustInfo.Models.CustomerOrderModels;

namespace CustInfo.Services.CustomerOrderServices
{
    public interface ICustomerOrderService
    {
        Task<bool> CreateCustomerOrderAsync(CustomerOrderCreate  model);
        Task<List<CustomerOrderListItem>> GetCustomerOrdersAsync();
        Task<CustomerOrderDetail> GetCustomerOrderDetailByIdAsync(int id);
        Task<bool> EditCustomerOrderAsync(CustomerOrderEdit model);
        Task<bool> DeleteCustomerOrder(int id);
        
    }
}