using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PostableRESTfulApi.Controllers.Error;
using PostableRESTfulApi.Data;
using PostableRESTfulApi.Models;
using PostableRESTfulApi.Models.DTOs.Post;
using PostableRESTfulApi.Models.DTOs.User;

namespace PostableRESTfulApi.Controllers
{
    [Route("api/me")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("")]
        public async Task<IActionResult> GetUser()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            if (userId == null)
            {
                return ErrorHelper.ErrorResponse(this, 401, "Unauthorized", "No se encontro el id del usuario autenticado");
            }

            var user = await _context.Users.FindAsync(int.Parse(userId));
            if (user == null)
            {
                return ErrorHelper.ErrorResponse(this, 401, "Unauthorized", "El usuario autenticado no existe en el sistema.");                
            }
            return Ok(user);
        }

        // PUT: api/me
        [Authorize]
        [HttpPut("")]
        public async Task<IActionResult> UpdateUser(UpdateUserDto updateUserDto)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            if (userId == null)
            {
                return ErrorHelper.ErrorResponse(this, 401, "Unauthorized", "No se encontro el id del usuario autenticado");
            }

            var user = await _context.Users.FindAsync(int.Parse(userId));
            if (user == null)
            {
                return ErrorHelper.ErrorResponse(this, 401, "Unauthorized", "El usuario autenticado no existe en el sistema.");                
            }

            if (updateUserDto.Email != null)
            {
                user.Email = updateUserDto.Email;
            }

            if (updateUserDto.FirstName != null)
            {
                user.FirstName = updateUserDto.FirstName;
            }

            if (updateUserDto.LastName != null)
            {
                user.LastName = updateUserDto.LastName;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return ErrorHelper.ErrorResponse(this, 500, "Internal Server Error", ex.Message);
            }
        
            return Ok(new { message = "User Actualizado.", user });                          
        }

        // DELETE: api/me
        [Authorize]
        [HttpDelete("")]
        public async Task<IActionResult> DeleteLike()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            if (userId == null)
            {
                return ErrorHelper.ErrorResponse(this, 401, "Unauthorized", "No se encontro el id del usuario autenticado");
            }

            var user = await _context.Users.FindAsync(int.Parse(userId));
            if (user == null)
            {
                return ErrorHelper.ErrorResponse(this, 401, "Unauthorized", "El usuario autenticado no existe en el sistema.");                
            }

            _context.Remove(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return ErrorHelper.ErrorResponse(this, 500, "Internal Server Error", ex.Message);
            }
            return NoContent();
        }
    }
}