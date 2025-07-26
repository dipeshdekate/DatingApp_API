using DatingApp.BAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers;
[ApiController]
[Route("api")]
public class MembersController : ControllerBase
{
    private readonly IApplicationMembers _applicationMembers;

    public MembersController(IApplicationMembers applicationMembers)
    {
        _applicationMembers = applicationMembers;
    }
    
    [HttpGet("Users")]
    public async Task<IActionResult> GetMembers()
    {
        var membersList = await _applicationMembers.GetAllUsersAsync();
        return Ok(membersList);
    }
}