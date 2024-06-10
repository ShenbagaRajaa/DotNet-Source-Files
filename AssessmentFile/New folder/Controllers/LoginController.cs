using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentFile;

public class LoginController:Controller
{
     public IActionResult Login(){
        return View();
    }
    [HttpPost]
    public IActionResult Login(string username, string password){
        ClaimsIdentity identity=null;
        ClaimsPrincipal claimsPrincipal=null;
        if(username.Equals("Shenba")&&password.Equals("PassWord")){
            identity = new ClaimsIdentity(new[]{
                new Claim(ClaimTypes.Name,username),
                new Claim(ClaimTypes.Role,"Manager")
            },CookieAuthenticationDefaults.AuthenticationScheme);
            claimsPrincipal = new ClaimsPrincipal(identity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,claimsPrincipal);
            return RedirectToAction("Index","Book");
        }
        if(username.Equals("Raj")&&password.Equals("PassWord")){
            identity = new ClaimsIdentity(new[]{
                new Claim(ClaimTypes.Name,username),
                new Claim(ClaimTypes.Role,"SalesMan")
            },CookieAuthenticationDefaults.AuthenticationScheme);
            claimsPrincipal = new ClaimsPrincipal(identity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,claimsPrincipal);
            return RedirectToAction("Index","Book");
        }
        return View();
    }
    public IActionResult Logout(){
        var logout = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Login","AccountLogin");
    }
}
