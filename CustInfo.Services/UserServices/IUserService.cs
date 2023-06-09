using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Models.UserModels;

namespace CustInfo.Services.UserServices
{
    public interface IUserService
    {
        Task<bool> CreateUser(UserCreate model);
        Task<List<UserListItem>> GetUserListItems();
        Task<UserDetail> GetUserDetailById(int UserId);
        Task<bool> EditUser (UserEdit model);
        Task<bool> DeleteUser (int UserId);
    }
}