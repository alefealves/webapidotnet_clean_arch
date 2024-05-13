using System.Globalization;
using Application.UseCases.AddCustomer;
using Domain.Contracts.repositories.AddCustomer;
using Domain.Contracts.UseCases.AddCustomer;
using FluentValidation;
using InfraRepository.Repositories.AddCustomer;
using WebApi.Models.AddCustomer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IAddCustomerRepository, AddCustomerRepository>();
builder.Services.AddScoped<IAddCustomerUseCase, AddCustomerUseCase>();
builder.Services.AddTransient<IValidator<AddCustomerInput>, AddCustomerInputValidator>();

builder.Services.AddControllers();
// Add services to the container.
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

var cultureInfo = new CultureInfo("pt-BR");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

app.Run();
