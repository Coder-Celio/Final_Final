using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustInfo.Data.Entities;
using CustInfo.Models.CustomerModels;
using CustInfo.Models.CustomerOrderModels;
using CustInfo.Models.UserModels;
using CustInfo.Models.VehicleModels;



namespace CustInfo.Services.Configurations
{
    public class MapperConfigurations : Profile
    {
        public MapperConfigurations()
        {
            CreateMap<CustomerEntity,CustomerCreate>().ReverseMap();
            CreateMap<CustomerEntity,CustomerDetail>().ReverseMap();
            CreateMap<CustomerEntity,CustomerEdit>().ReverseMap();
            CreateMap<CustomerEntity,CustomerList>().ReverseMap();

            CreateMap<CustomerOrderEntity,CustomerOrderCreate>().ReverseMap(); 
            CreateMap<CustomerOrderEntity,CustomerOrderDetail>().ReverseMap(); 
            CreateMap<CustomerOrderEntity,CustomerOrderListItem>().ReverseMap();
            CreateMap<CustomerOrderEntity,CustomerOrderEdit>().ReverseMap();

            CreateMap<UserEntity,UserCreate>().ReverseMap(); 
            CreateMap<UserEntity,UserDetail>().ReverseMap();
            CreateMap<UserEntity,UserListItem>().ReverseMap();
            CreateMap<UserEntity,UserEdit>().ReverseMap();

            CreateMap<VehicleEntity,VehicleCreate>().ReverseMap(); 
            CreateMap<VehicleEntity,VehicleDetail>().ReverseMap(); 
            CreateMap<VehicleEntity,VehicleEdit>().ReverseMap(); 
            CreateMap<VehicleEntity,VehicleList>().ReverseMap(); 
             
        }
    }
}