using AutoMapper;
using Registration.Api.Controllers;
using Registration.Fasade.Dtos;
using Registration.Fasade.Interfaces.Repository;
using Registration.Fasade.Interfaces.Service;
using Registration.Fasade.Option;
using Registration.Repository;
using Registration.Repository.Data;
using Registration.Service;

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)!.FullName)
    .AddJsonFile("appsettings.json")
    .Build();

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddDbContext<RegistrationContext>()
    .Configure<RepositoryOption>(x => x.ConnectionString = configuration.GetConnectionString("Default"));
DBHelper.CreateDatabase();
builder.Services.AddScoped<IRegistrationRepository, RegistrationRepository>();
builder.Services.AddScoped(typeof(IServiceRepositoryBase<RegistrationDto>),typeof(ServiceRepositoryBase<RegistrationDto>));
builder.Services.AddScoped(typeof(IRepositoryBase<RegistrationDto>),typeof(RepositoryBase<RegistrationDto>));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();




