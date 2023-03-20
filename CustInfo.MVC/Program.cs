using CustInfo.Data.Context;
using CustInfo.Services.Configurations;
using CustInfo.Services.CustomerOrderServices;
using CustInfo.Services.CustomerServices;
using CustInfo.Services.UserServices;
using CustInfo.Services.VehicleServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MapperConfigurations));
builder.Services.AddScoped<IVehicleService,VehicleService>();
builder.Services.AddScoped<ICustomerOrderService,CustomerOrderService>();
builder.Services.AddScoped<ICustomerService,CustomerService>();
builder.Services.AddScoped<IUserService,UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
