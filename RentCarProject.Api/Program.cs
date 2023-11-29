using Microsoft.EntityFrameworkCore;
using RentCarProject.Services.Interfaces;
using RentCarProject.Services.Services;
using RentCarProject_Application.Data;
using RentCarProject_Application.Interfaces;
using RentCarProject_Application.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RentCarDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IRenterRepository, RenterRepository>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ILessorRepository, LessorRepository>();
builder.Services.AddScoped<IRenterService, RenterService>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ILessorService, LessorService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
 
    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
