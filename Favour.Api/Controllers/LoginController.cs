using Favour.Api.Models;
using Favour.Application.Interfaces;
using Favour.Core.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Favour.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IFavourContext DbContext;
        public LoginController(IFavourContext DbContext)
        {
            this.DbContext = DbContext;
        }
        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginModel login)
        {

            var user = await DbContext.Accounts.Where(ac => login.UserName == ac.Name && login.Password == login.Password).FirstOrDefaultAsync();
            if (user == null)
            {
                return (ActionResult)Results.Unauthorized();
            }
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, login.UserName) };
            var jwt = new JwtSecurityToken(
            issuer: AuthOptions.ISSUER,
            audience: AuthOptions.AUDIENCE,
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromDays(15)), 
            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                access_token = encodedJwt,
                username = user.Name
            };
            return (ActionResult)Results.Json(response);
        }

    }
}
