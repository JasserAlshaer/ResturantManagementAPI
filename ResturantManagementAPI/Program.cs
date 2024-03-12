using Microsoft.EntityFrameworkCore;
using ResturantManagementAPI.Implmentations;
using ResturantManagementAPI.Interfaces;
using ResturantManagementAPI.Models.Context;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ResturantManagementDbContext>(cop=>
cop.UseSqlServer(builder.Configuration.GetValue<string>("sqlconnect")));
//try to register implementation class
builder.Services.AddScoped<ISharedInterface, SharedImplementation>();

//Serilog Config
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("C:\\Users\\ASUS\\Desktop\\Logs\\logger.txt")
    .CreateLogger();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
Log.Information("Application Has been Started");
app.Run();
