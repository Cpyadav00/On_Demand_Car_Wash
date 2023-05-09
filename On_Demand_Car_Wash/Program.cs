using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Nest;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;
using On_Demand_Car_Wash.Repository;
using On_Demand_Car_Wash.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CarDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IAddress,AddressRepository>();
builder.Services.AddScoped<AddressService, AddressService>();

builder.Services.AddScoped<IAdmin, AdminRepository>();
builder.Services.AddScoped<ICar , CarRepository>();
builder.Services.AddScoped <IOrder,OrderRepository > ();
builder.Services.AddScoped < IPackage,PackageRepository > ();
//builder.Services.AddScoped <IRepository<UserDetails,int>,UserRepository > ();
builder.Services.AddScoped < IViewInvoice, ViewInvoiceRepository> ();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
