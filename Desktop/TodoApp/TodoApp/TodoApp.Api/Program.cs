using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TodoApp.Api.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var configuration = builder.Configuration;
string connectionString = configuration.GetConnectionString("TodoDatabaseConnection");
builder.Services.AddDbContext<TodoContext>(options =>
options.UseSqlServer(configuration.GetConnectionString(connectionString)));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
