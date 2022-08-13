using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Domain.Models;
using Repository.Data;
using Repository.Repositories;
using Services;
using Services.Interfaces;
using Services.Models;
using Services.MappingConfigurations;
using Services.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FileManagmentSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FileManagmentSystemContext") ?? throw new InvalidOperationException("Connection string 'FileManagmentSystemContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program) , typeof(MappingProfile));
builder.Services.AddScoped<IService<FileManagmentSystemContext, FileModel, FileDTO>,FileService>();
builder.Services.AddScoped<IRepository<FileManagmentSystemContext, FileModel >, FileRepository>();
//builder.Services.AddScoped<IUnitOfWork<FileManagmentSystemContext, BaseModel>, UnitOfWork();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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
