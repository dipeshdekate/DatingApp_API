using DatingApp.Models.Entities;

namespace DatingApp.DAL.Interfaces;

public interface IApplicationUsersAccess
{
    Task<IEnumerable<AppUser>> GetAllUsersAsync();
}