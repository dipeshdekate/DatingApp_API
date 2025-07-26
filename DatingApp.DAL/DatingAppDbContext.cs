using DatingApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.DAL;

public class DatingAppDbContext(DbContextOptions<DatingAppDbContext> options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}