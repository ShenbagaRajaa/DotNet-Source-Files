using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TypeWrittingBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Configuration;
using System.Drawing;

namespace TypeWrittingBack;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserDetailsContext userContext;
    private readonly IConfiguration config;
    public UserController(UserDetailsContext context, IConfiguration configuration)
    {
        userContext = context;
        config = configuration;
    }
    
    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<UserDetailsShenba>>> GetAllStudentDetials()
    {
        return await userContext.UserDetailsShenba.ToListAsync();
    }

    [HttpGet("GetById/{id}")]
    public async Task<ActionResult<UserDetailsShenba>> GetParticularStudent(int id)
    {
        return await userContext.UserDetailsShenba.FindAsync(id);
    }

    [HttpPost("Register")]
    public async Task<ActionResult<UserDetailsShenba>> Register(frontenduser frontenduser)
    {
        byte[] passalt = PasswordHasher.GenerateSalt();
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingUser = await userContext.UserDetailsShenba
            .FirstOrDefaultAsync(u => u.UserName == frontenduser.Username);

        if (existingUser != null)
        {
            return BadRequest("Username already exists");
        }

        var user = new UserDetailsShenba
        {
            UserName = frontenduser.Username,
            Email = frontenduser.Email,
            Type = frontenduser.Type,
            PasswordSalt = Convert.ToBase64String(passalt),
            PasswordHash = PasswordHasher.ComputeHash(frontenduser.Password, passalt)
        };
        userContext.UserDetailsShenba.Add(user);
        await userContext.SaveChangesAsync();
        return CreatedAtAction("GetParticularStudent", new { id = user.StudentId }, user);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(frontendLogin frontendlogin)
    {
        var user = await userContext.UserDetailsShenba
            .FirstOrDefaultAsync(u => u.UserName == frontendlogin.Username);
        if (user == null)
        {
            return BadRequest("Enter username or password");
        }
        if (user.Type != frontendlogin.Type){
            return BadRequest("Type and User not matched");
            // var Response="Login Success";
            // return Ok(Response);
            // return StatusCode(400);

        }
        bool passwordMatches = PasswordHasher.VerifyHashedPassword(frontendlogin.Password, user.PasswordSalt, user.PasswordHash);

        if (!passwordMatches)
        {
            return BadRequest("Invalid username or password");
            // var Response="Login Success";
            // return Ok(Response);
        }
        var securityKey = PasswordHasher.GetSigningKey();
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
        new Claim(ClaimTypes.NameIdentifier, user.StudentId.ToString()),
        };

        var token = new JwtSecurityToken(
            issuer: "your_api_domain", 
            audience: "your_api_domain", 
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(30), 
            signingCredentials: credentials
        );

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenString = tokenHandler.WriteToken(token);
        return Ok(new { token = tokenString });
    }
    
    // 
}
