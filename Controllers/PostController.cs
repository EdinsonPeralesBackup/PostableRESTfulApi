using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
                return BadRequest("El usuario no existe!!");
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

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);
        }

        // [Authorize(Policy = "UserOnly")]
        // [HttpGet("user")]
        // public IActionResult GetUserProducts()
        // {
        //     var products = _context.Products.ToList();
        //     return Ok(products);
        // }

        // [Authorize(Policy = "AdminOnly")]
        // [HttpPost("admin")]
        // public IActionResult CreateProduct([FromBody] Product product)
        // {
        //     _context.Products.Add(product);
        //     _context.SaveChanges();
        //     return Ok(new { message = "Product created successfully" });
        // }
    }
}