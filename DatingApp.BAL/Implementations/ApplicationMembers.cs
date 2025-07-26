using DatingApp.BAL.Interfaces;
using DatingApp.DAL.Interfaces;
using DatingApp.Models.Entities;

namespace DatingApp.BAL.Implementations;

public class ApplicationMembers : IApplicationMembers
{
    private readonly IApplicationUsersAccess _applicationUsersAccess;

    public ApplicationMembers(IApplicationUsersAccess applicationUsersAccess)
    {
        _applicationUsersAccess = applicationUsersAccess;
    }
    
    public async Task<IEnumerable<AppUser>> GetAllUsersAsync()
    {
        return await _applicationUsersAccess.GetAllUsersAsync();
    }
}