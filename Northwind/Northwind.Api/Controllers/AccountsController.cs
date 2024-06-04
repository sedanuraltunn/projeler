using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Northwind.Api.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Northwind.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountsController : ControllerBase
{
    [HttpPost]
    public IActionResult Login([FromBody] LoginModel loginModel)
    {
        if (loginModel.UserName != "snaltun" && loginModel.Password != "12345")
            return BadRequest("Kullanıcı adı veya şifre hatalı");

        var claims = new List<Claim> //jwt token payloaddaki her bilgi claim'dir
        {
            new Claim("id","1"),
            new Claim("username",loginModel.UserName),
            new Claim("mail","test@test.com"),
            new Claim("role","Superuser"),
            new Claim("role","Moderator"),
        };

        var issuer = "http://abc.com";
        var key = "komplex_salt_key$)(3infoAGHT#573sg";

        var credential = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)), "HS256");
        var payload = new JwtPayload(issuer, issuer, claims, null, DateTime.Now.AddDays(7.0), DateTime.Now);

        JwtSecurityToken token = new JwtSecurityToken(new JwtHeader(credential), payload);
        var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

        return Ok(new 
        { 
            token = jwtToken, type = "Bearer" 
        });
    }
}
