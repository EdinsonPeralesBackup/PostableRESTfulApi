using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PostableRESTfulApi.Data;
using PostableRESTfulApi.Models;
using PostableRESTfulApi.Models.DTOs.Post;

namespace PostableRESTfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetPosts(
            string username = "", 
            string orderBy = "createdAt", 
            string order = "asc",
            int pageNumber = 1,
            int pageSize = 10)
        {
            // Start with querying the Posts
            IQueryable<Post> query = _context.Posts.Include(p => p.User).Include(p => p.Likes);

            // Apply username filter if provided
            if (!string.IsNullOrEmpty(username))
            {
                query = query.Where(p => p.User.UserName.ToLower() == username.ToLower());
            }

            // Apply sorting
            switch (orderBy.ToLower())
            {
                case "createdAt":
                    query = (order.ToLower() == "asc") ? query.OrderBy(p => p.CreatedAt) : query.OrderByDescending(p => p.CreatedAt);
                    break;
                case "likesCount":
                    // You may need to calculate likes count if not directly stored in Post entity
                    // For simplicity, assuming it's directly available
                    query = (order.ToLower() == "asc") ? query.OrderBy(p => p.Likes.Count) : query.OrderByDescending(p => p.Likes.Count);
                    break;
                default:
                    // Default to sorting by createdAt if orderBy value is not recognized
                    query = (order.ToLower() == "asc") ? query.OrderBy(p => p.CreatedAt) : query.OrderByDescending(p => p.CreatedAt);
                    break;
            }
            //Pagination
            var totalCount = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            
            // Execute the query and return results with pagination metadata
            var posts = await query
            .Select(p => new 
                {
                    p.Id,
                    p.Content,
                    p.CreatedAt,
                    User = new
                    {
                        p.User.Id,
                        p.User.UserName
                    },
                    LikesCount = p.Likes.Count
                }).ToListAsync();

            var response = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Posts = posts
            };

            return Ok(response);
        }

        // GET: api/post/{{id}}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            var post = await _context.Posts
                .Include(p => p.User) 
                .Where(p => p.Id == id)
                .Select(p => new 
                {
                    p.Id,
                    p.Content,
                    p.CreatedAt,
                    User = new 
                    {
                        p.User.Id,
                        p.User.UserName
                    }
                })
                .FirstOrDefaultAsync();

            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [Authorize]
        [HttpPost("")]
        public async Task<ActionResult<Post>> CreatePost([FromBody] CreatePostWithoutIdDto postDto)
        {
            var user = await _context.Users.FindAsync(postDto.UserId);            

            if (user == null)
            {
                return BadRequest($"ERROR: El usuario con id {postDto.UserId} no existe!!");
                throw new InvalidOperationException();
            }

            var post = new Post
            {
                Content = postDto.Content,
                User = user,
                CreatedAt = postDto.CreatedAt ?? DateTime.Now,
            };

            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            
            var postResponse = new 
            {
                content = postDto.Content,
                user = new {
                    id = user.Id,
                    username = user.UserName
                },
                createdAt = postDto.CreatedAt ?? DateTime.Now,
            };

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, postResponse);
        }

        // PUT: api/post/{{id}}
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, UpdatePostDto updatePostDto)
        {
            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                return NotFound($"ERROR: El post con id {id} no existe");
            }

            if (updatePostDto.UserId.HasValue)
            {
                var user = await _context.Users.FindAsync(updatePostDto.UserId);
                if (user == null)
                {
                    return BadRequest($"ERROR: El usuario con id {updatePostDto.UserId} no existe");
                }
                post.User = user;
            }

            if (updatePostDto.Content != null)
            {
                post.Content = updatePostDto.Content;
            } 
            await _context.SaveChangesAsync(); 

            var updatedPost = new 
            {
                post.Id,
                post.Content,
                post.CreatedAt,
                User = new 
                {
                    post.User.Id,
                    post.User.UserName
                }
            };
            return Ok(new { message = "Post Actualizado.", updatedPost });                          
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