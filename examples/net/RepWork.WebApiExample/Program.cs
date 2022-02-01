using Microsoft.EntityFrameworkCore;

using RepWork.RepositoryLayerExample.EntityFrameworkCore;
using RepWork.ServiceLayerExample;
using RepWork.ServiceLayerExample.Abstract;
using RepWork.ServiceLayerExample.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ExampleDbContext>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("ExampleConnection")));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IExampleUnitOfWork, ExampleUnitOfWork>();

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