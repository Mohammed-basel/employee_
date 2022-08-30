using emplyee_api.services;
using Microsoft.AspNetCore.Mvc;
using static emplyee_api.services.IEmplyee;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IEmplyee, emplyeesservices>();
builder.Services.AddSingleton<ICompany, companyservices>();
builder.Services.AddMvc(options =>
{
    options.Filters.Add(new RequireHttpsAttribute());
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
