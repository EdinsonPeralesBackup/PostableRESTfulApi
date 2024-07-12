using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
                return Unauthorized("No se encontro el id del usuario autenticado");
            }

            var user = await _context.Users.FindAsync(int.Parse(userId));
            if (user == null)
            {
                return Unauthorized("El usuario autenticado no existe en el sistema.");
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
                return Unauthorized("No se encontro el id del usuario autenticado");
            }

            var user = await _context.Users.FindAsync(int.Parse(userId));
            if (user == null)
            {
                return Unauthorized("El usuario autenticado no existe en el sistema.");
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
                return BadRequest($"ERROR: {ex.Message}");
            }
        
            return Ok(new { message = "User Actualizado.", user });                          
        }

        [Authorize]
        [HttpPost("{postId}/like")]
        public async Task<IActionResult> GiveLike(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);            

            if (post == null)
            {
                return NotFound($"ERROR: El post con id {postId} no existe!!");
                throw new InvalidOperationException();
            } 

            var userId = User.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            if (userId == null)
            {
                return Unauthorized("No se encontro el id del usuario autenticado");
            }

            var user = await _context.Users.FindAsync(int.Parse(userId));
            if (user == null)
            {
                return Unauthorized("El usuario autenticado no existe en el sistema.");
            }

            var like = new Like
            {
                Post = post,
                User = user,
                CreatedAt = DateTime.Now
            };            

            _context.Likes.Add(like);
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 2627)
                {
                    // Error 2627 es para violación de clave única en SQL Server
                    return BadRequest("El usuario ya ha dado like a este post.");
                }
                else
                {
                    // Manejar otros errores de actualización de base de datos
                    return StatusCode(500, "Ocurrió un error al registrar el like.");
                }
            }

            var likeResponse = new 
            {
                id = like.Id,
                content = post.Content,
                createdAt = like.CreatedAt,
                username = user.UserName,
                likesCount = like.Post.Likes.Count
            };
            return Ok(new { message = "Like registrado.", likeResponse });         
        }

        [Authorize]
        [HttpDelete("{postId}/like")]
        public async Task<IActionResult> DeleteLike(int postId)
        {
            var post = await _context.Posts.FindAsync(postId); 

            if (post == null)
            {
                return NotFound($"El post con id {postId} no existe!!!");
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            if (userId == null)
            {
                return Unauthorized("No se encontro el id del usuario autenticado");
            }

            var user = await _context.Users.FindAsync(int.Parse(userId));
            if (user == null)
            {
                return Unauthorized("El usuario autenticado no existe en el sistema.");
            }

            var like = await _context.Likes
                .FirstOrDefaultAsync(l => l.UserId == user.Id && l.PostId == post.Id);
            if (like == null)
            {
                return NotFound($"El post no tenía like anteriormente!!!");
            }

            _context.Remove(like);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return BadRequest($"ERROR: {ex.Message}");
            }
            return Ok(new { message = "Like Eliminado."});
        }
    }
}