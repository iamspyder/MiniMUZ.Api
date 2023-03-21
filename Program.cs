using Microsoft.EntityFrameworkCore;
using MiniMUZ.Api.MuzModels;
using MiniMUZ.Api.MuzModels.DTO.Vehicle;
using MiniMUZ.Api.MuzModels.Repository;
using MiniMUZ.Api.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MiniMuzContext>(opt => opt.UseSqlServer("Data Source=DESKTOP-RFV73GF\\SQLEXPRESS;Initial Catalog=loyaltyprogram;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
builder.Services.AddTransient<IMuz<Vehicle, VehiceDTO>, DVehicle>();
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
