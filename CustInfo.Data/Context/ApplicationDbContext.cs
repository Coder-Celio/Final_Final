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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleEntity>().HasData(
                new VehicleEntity
                {
                    VehicleId=1,
                    Year=2020,
                    Make="Toyota",
                    Model="Supra",
                    CustomerId=0
                },
                new VehicleEntity
                {
                    VehicleId=2,
                    Year=2021,
                    Make="Toyota",
                    Model="Supra",
                    CustomerId=1
                },
                new VehicleEntity
                {
                    VehicleId=3,
                    Year=2022,
                    Make="Toyota",
                    Model="Supra",
                    CustomerId=3
                }
            );
        }
    }
}