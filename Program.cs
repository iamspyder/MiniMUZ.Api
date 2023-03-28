using Microsoft.EntityFrameworkCore;
using MiniMUZ.Api.MuzModels;
using MiniMUZ.Api.MuzModels.Data_Manager;
using MiniMUZ.Api.MuzModels.DTO.Shipment;
using MiniMUZ.Api.MuzModels.DTO.Vehicle;
using MiniMUZ.Api.MuzModels.DTO.Item;
using MiniMUZ.Api.MuzModels.Repository;
using MiniMUZ.Api.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using MiniMUZ.Api.MuzModels.DTO.Dispatch;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MiniMuzContext>(opt => opt.UseSqlServer("Data Source=DESKTOP-RFV73GF\\SQLEXPRESS;Initial Catalog=loyaltyprogram;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<MiniMuzContext>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<MiniMuzContext>()
    .AddDefaultTokenProviders();
builder.Services.AddTransient<IMuz<Vehicle, VehiceDTO>, DVehicle>();
builder.Services.AddTransient<IMuz<Shipment, ShipmentDTO>, DShipment>();
builder.Services.AddTransient<IMuz<Item, ItemDTO>, DItem>();
builder.Services.AddTransient<IMuz<Dispatch, DispatchDTO>, DDispatch>();
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
