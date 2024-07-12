using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PostableRESTfulApi.Data;
using PostableRESTfulApi.Models;
using PostableRESTfulApi.Models.DTOs.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PostableRESTfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public AuthController(IConfiguration configuration,ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Register([FromBody] CreateUserWithoutIdDto userDto)
        {
            try
            {
                var user = new User
                {
                    UserName  = userDto.UserName,
                    Password  = userDto.Password,
                    Email     = userDto.Email ?? null,
                    FirstName = userDto.FirstName ?? null,
                    LastName  = userDto.LastName ?? null,
                    Role      = userDto.Role ?? "User",
                    CreatedAt = userDto.CreatedAt ?? DateTime.Now
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return Ok(new { message = "User registered successfully", user });
            }
            catch (DbUpdateException ex) when ((ex.InnerException as Microsoft.Data.SqlClient.SqlException)?.Number == 2601)
            {
                return BadRequest($"ERRPR: El nombre del usuario ya esta en uso.");
                throw;
            }
            catch (System.Exception ex)
            {
                return BadRequest($"ERROR: {ex.Message} ");
                throw;
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUserDto loginUserDto)
        {
            var user = _context.Users.FirstOrDefault(
                u => u.UserName == loginUserDto.UserName 
                && u.Password == loginUserDto.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Implementación de logout si es necesario
            return Ok(new { message = "User logged out successfully" });
        }
    }
}