namespace DatingApp.Models.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Email { get; set; } 
    public required string Username { get; set; }
}