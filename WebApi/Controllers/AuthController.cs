using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Model;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly JobPortalDbContext _context;

    public AuthController(JobPortalDbContext context)
    {
        _context = context;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(Login dto)
    {
        if (_context.Users.Any(u => u.UserName == dto.UserName))
            return BadRequest("Username already exists.");

        var user = new User
        {
            UserName = dto.UserName,
            Password = dto.Password  
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok("User registered successfully.");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(Login dto)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.UserName == dto.UserName && u.Password == dto.Password);

        if (user == null)
            return Unauthorized("Invalid username or password.");

        return Ok(new
        {
            Message = "Login successful",
            Username = user.UserName,
            Role = user.Role
        });
    }
}
