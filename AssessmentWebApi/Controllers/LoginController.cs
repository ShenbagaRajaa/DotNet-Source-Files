using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;


namespace AssessmentWebApi;

[Route("api/[controller]")]
[ApiController]
public class LoginController:ControllerBase
{
    private readonly IConfiguration config;
    public LoginController(IConfiguration configuration){
        config=configuration;
    }
    // [AllowAnonymous]
    [HttpPost]
    public ActionResult Login([FromBody] UserLogin userLogin){
        // Console.WriteLine("hiiiiii");
        var user=Authenticate(userLogin);
        if(user != null){
            var token=GenerateToken(user);
            return Ok(token);
        }
        return NotFound("User Not Found");
    }
    private string GenerateToken(UserModel user){
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]{
            new Claim(ClaimTypes.NameIdentifier,user.Username),
            new Claim(ClaimTypes.Role, user.Role)
        };
        var token = new JwtSecurityToken(config["Jwt:Issuer"],
        config["Jwt:Audience"],
        claims,
        expires:DateTime.Now.AddMinutes(15),
        signingCredentials:credentials);
        return new JwtSecurityTokenHandler().WriteToken(token);

    }
    private UserModel Authenticate(UserLogin userLogin){
        var currentUser = UserConstants.Users.FirstOrDefault(x => x.Username.ToLower() == userLogin.Username.ToLower() && x.Password==userLogin.Password);
        if(currentUser != null){
            return currentUser;
        }
        return null;
    }
}