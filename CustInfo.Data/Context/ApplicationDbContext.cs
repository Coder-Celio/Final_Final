using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustInfo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustInfo.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {}
        public DbSet<CustomerEntity> Customers {get; set;}
        public DbSet<CustomerOrderEntity> CustomerOrders {get; set;}
        public DbSet<UserEntity> Users {get; set;}
        public DbSet<VehicleEntity> Vehicles {get; set;}
    }
}