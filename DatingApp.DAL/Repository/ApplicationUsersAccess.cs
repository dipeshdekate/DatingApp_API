using DatingApp.DAL.Interfaces;
using DatingApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.DAL.Repository;

public class ApplicationUsersAccess : IApplicationUsersAccess
{
    private readonly DatingAppDbContext _context;

    public ApplicationUsersAccess(DatingAppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<AppUser>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}