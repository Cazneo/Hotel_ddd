// UserController.cs
using Microsoft.AspNetCore.Mvc;
using User_API.Model;
using User_API.DTOs;
using User_API.Services;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateAccount([FromBody] UserDto userDto)
    {
        if (string.IsNullOrEmpty(userDto.FullName) || string.IsNullOrEmpty(userDto.EmailAddress))
        {
            return BadRequest("Les informations nécessaires ne sont pas fournies.");
        }

        var newUser = new User
        {
            FullName = userDto.FullName,
            EmailAddress = userDto.EmailAddress,
            PhoneNumber = userDto.PhoneNumber,
            UniqueIdentifierUid = GenerateUniqueIdentifier()
        };

        await _userService.CreateUserAsync(newUser);

        return Ok(new { userId = newUser.UserId, uniqueIdentifier = newUser.UniqueIdentifierUid });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UserDto userDto)
    {
        var success = await _userService.UpdateUserAsync(id, userDto);
        if (!success)
        {
            return NotFound();
        }
        return Ok();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _userService.DeleteUserAsync(id);
        if (!success)
        {
            return NotFound();
        }
        return Ok();
    }

    private string GenerateUniqueIdentifier()
    {
        return Guid.NewGuid().ToString();
    }
}
