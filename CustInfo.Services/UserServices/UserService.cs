using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustInfo.Data.Context;
using CustInfo.Data.Entities;
using CustInfo.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace CustInfo.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public UserService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateUser(UserCreate model)
        {
            var UserCreate = new UserEntity
            {
                UserId = model.UserId,
                UserName = model.UserName,
                Password = model.Password,
                ProfileCreated = model.ProfileCreated
            };
            await _context.Users.AddAsync(UserCreate);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteUser(int UserId)
        {
            var UserEntity = await _context.Users.FindAsync(UserId);
            if(UserEntity != null){
                _context.Users.Remove(UserEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            else{
                return false;
            }
        }

        public async Task<bool> EditUser(UserEdit model)
        {
            var UserEdit = await _context.Users.FindAsync(model.UserId);
            if(UserEdit is null)
            return false;
            
            UserEdit.UserId = model.UserId;
            UserEdit.UserName = model.UserName;
            UserEdit.Password = model.Password;

            return await _context.SaveChangesAsync() >0;
        }

        public async Task<UserDetail> GetUserDetailById(int UserId)
        {
            var UserDetail = await _context.Users.FindAsync(UserId);
            if(UserDetail == null)
            return default;

            return new UserDetail{
                UserId = UserDetail.UserId,
                UserName = UserDetail.UserName,
                Password = UserDetail.Password,
                ProfileCreated = UserDetail.ProfileCreated
            };
        }

        public async Task<List<UserListItem>> GetUserListItems()
        {
            var conversion = await _context.Users.ToListAsync();
            return _mapper.Map<List<UserListItem>>(conversion);
        }
    }
}