using AutoMapper;
using BusinessLogicLayer.Commons.Mapper;
using BusinessLogicLayer.Interfaces.Branches;
using BusinessLogicLayer.Interfaces.Receipts;
using BusinessLogicLayer.Interfaces.Users;
using BusinessLogicLayer.Services.Branches;
using BusinessLogicLayer.Services.Receipts;
using BusinessLogicLayer.Services.Users;
using DataAccesLayer.Data;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Interfaces.Branches;
using DataAccesLayer.Interfaces.Users;
using DataAccesLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserRoleService, UserRoleService>();
builder.Services.AddTransient<IBranchService, BranchService>();
builder.Services.AddTransient<IReceiptService, ReceiptService>();

builder.Services.AddAutoMapper(typeof(MapperProfile));

builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connection = builder.Configuration.GetConnectionString("DefaultConnection");

    options.UseNpgsql(connection);

    options.UseNpgsql(connection, b => b.MigrationsAssembly("DataAccesLayer"));
});

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
