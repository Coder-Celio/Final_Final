using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Models.UserModels;

namespace CustInfo.Services.UserServices
{
    public class UserService : IUserService
    {
        public Task<bool> CreateUser(UserCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetail> GetUserDetailById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserListItem>> GetUserListItems()
        {
            throw new NotImplementedException();
        }
    }
}