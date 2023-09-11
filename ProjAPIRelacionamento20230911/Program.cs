using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjAPIRelacionamento20230911.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjAPIRelacionamento20230911Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjAPIRelacionamento20230911Context") ?? throw new InvalidOperationException("Connection string 'ProjAPIRelacionamento20230911Context' not found.")));

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
