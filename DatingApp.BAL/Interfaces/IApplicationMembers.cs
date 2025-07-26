using DatingApp.Models.Entities;

namespace DatingApp.BAL.Interfaces;

public interface IApplicationMembers
{
    Task<IEnumerable<AppUser>> GetAllUsersAsync();
}