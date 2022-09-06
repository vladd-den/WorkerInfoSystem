
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using WIS.BLL.Services.DI;
using WIS.Data.DataAccess;
using WIS.Data.DataAccess.DI;
using WIS.Data.DataAccess.Interfaces.Repository;
using WIS.Data.DataAccess.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var dbConnection = builder.Configuration.GetConnectionString("WISDB_ConnectionString");
builder.Services.AddDbContext<WISDataContext>(o => o.UseSqlServer(dbConnection));
builder.Services.AddRepositories();
builder.Services.AddServices();

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
