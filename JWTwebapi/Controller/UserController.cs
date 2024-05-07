using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IO.Compression;

namespace JWTwebapi;

[Route("api/[controller]")]
[ApiController]
public class UserController:ControllerBase
{
    [HttpGet]
    [Route("role")]
    [Authorize(Roles ="CTO")]
    public IActionResult AdminEndPoint(){
        var currentUser = GetCurrentUser();
        return Ok($"Hi ! {currentUser.Username}, your are {currentUser.Role}");
    }
    private UserModel GetCurrentUser(){
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        if(identity != null){
            var userClaims = identity.Claims;
            return new UserModel{
                Username = userClaims.FirstOrDefault(x => x.Type==ClaimTypes.NameIdentifier)?.Value,
                Role = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value
            };
        }
        return null;
    }
}

// ,
//   "Jwt": {
//     "Key": "ACDt1vR3lXToPQ1g3MyN",
//     "Issuer": "http://localhost:28747/", 
//     "Audience": "http://localhost:28747/"
//   }