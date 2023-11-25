using DomainFinal.Interfaces;
using InfrastructureFinal;
using AppFinal;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connectiongString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddInfrastructure(connectiongString);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy("Default", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.InstallApps();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("Default");

app.UseAuthorization();

app.MapControllers();

app.Run();
