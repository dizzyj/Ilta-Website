using IltaWebApp.Data;
using IltaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace IltaWebApp.Controllers
{
    [Route("blogs")]
    [ApiController]
    public class BlogPostController : Controller
    {
        private readonly BlogPostContext _db;

        public BlogPostController(BlogPostContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<BlogPost>>> GetBlogPosts()
        {
            return (await _db.BlogPosts.ToListAsync()).OrderByDescending(s => s.CreatedAt).ToList();
        }
    }
}
