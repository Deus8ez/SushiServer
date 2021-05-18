using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SushiApi.Data;
using SushiApi.Models;

namespace SushiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly SushiContext _context;

        public UsersController(SushiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> AuthorizeUser(User user)
        {

            var dbuser = await _context.Users.FirstOrDefaultAsync(p => p.Email == user.Email && p.Password == user.Password);

            if (dbuser != null)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KeyForSignInSecret@1234"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "https://localhost:5001",
                    audience: "http://localhost:8080",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString, userNickname = dbuser.Nickname});

            };

            return null;
        }
    }
}
