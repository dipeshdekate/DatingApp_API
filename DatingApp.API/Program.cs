using DatingApp.BAL.Implementations;
using DatingApp.BAL.Interfaces;
using DatingApp.DAL;
using DatingApp.DAL.Interfaces;
using DatingApp.DAL.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DatingAppDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Business Layer
builder.Services.AddTransient<IApplicationMembers, ApplicationMembers>();

//Repositories
builder.Services.AddScoped<IApplicationUsersAccess, ApplicationUsersAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();