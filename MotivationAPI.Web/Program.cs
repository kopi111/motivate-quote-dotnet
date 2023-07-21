

using MotivationAPI.ApplicationService.Services;
using MotivationAPI.Core.Interfaces.Repositories;
using MotivationAPI.Core.Interfaces.Services;
using MotivationAPI.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMotivationalQuotesService, MotivationAPIServices>();
builder.Services.AddScoped<IMotivationalRepository, MotivationalRepository>();
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
