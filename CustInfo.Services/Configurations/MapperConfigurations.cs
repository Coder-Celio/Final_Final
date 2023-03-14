using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustInfo.Models.CustomerModels;
using CustInfo.Models.CustomerOrderModels;
using CustInfo.Models.UserModels;
using CustInfo.Models.VehicleModels;

namespace CustInfo.Services.Configurations
{
    public class MapperConfigurations : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<Customer,CustomerCreate>().ReverseMap();
            CreateMap<Customer,CustomerDetail>().ReverseMap();
            CreateMap<Customer,CustomerEdit>().ReverseMap();
            CreateMap<Customer,CustomerList>().ReverseMap();

            CreateMap<CustomerOrder,CustomerOrderCreate>().ReverseMap(); 
            CreateMap<CustomerOrder,CustomerOrderDetail>().ReverseMap(); 
            CreateMap<CustomerOrder,CustomerOrderListItem>().ReverseMap();

            CreateMap<User,UserDetail>().ReverseMap(); 
            CreateMap<User,UserLogIn>().ReverseMap();

            CreateMap<Vehicle,VehicleCreate>().ReverseMap(); 
            CreateMap<Vehicle,VehicleDetail>().ReverseMap(); 
            CreateMap<Vehicle,VehicleEdit>().ReverseMap(); 
            CreateMap<Vehicle,VehicleList>().ReverseMap(); 
             
        }
    }
}