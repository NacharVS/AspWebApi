using Microsoft.EntityFrameworkCore;
using WebApiSecond.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connection = builder.Configuration.GetConnectionString("VodaDb");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<VodaContext>(x => x.UseSqlServer(connection, builder => builder.MigrationsAssembly("WebApiSecond")));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
