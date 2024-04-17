using AutoMapper;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Application.ValueObj.Extentions;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Infrastracture.Implement.Repository.ReadOnly;
using FilmMoi.Infrastracture.Implement.Repository.ReadWrite;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();//Required

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FlimMoiContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//required
builder.Services.AddTransient<IGenresReadOnlyRepository, GenresReadOnlyRepository>();//required
builder.Services.AddTransient<IReadWriteRepository<Genres>, GenresReadWriteRepository>();//required

builder.Services.AddCors(options =>////
{
    options.AddPolicy("AllowLocalhost",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
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
app.UseCors("AllowLocalhost");////
app.MapControllers();

app.Run();
