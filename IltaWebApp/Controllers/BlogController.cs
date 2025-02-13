using IltaWebApp.Data;
using IltaWebApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Runtime.CompilerServices;
namespace IltaWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;

        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var blog = _db.BlogPosts.Find(id);
            if(blog == null) return NotFound();
            _db.BlogPosts.Remove(blog);
            _db.SaveChanges();
            return NoContent();
        }

		[HttpPut("{id}")]
        public IActionResult Update(CreateBlogRequest request,int id)
        {
            var blog = _db.BlogPosts.Find(id);
            if(blog == null) return NotFound();
            blog.Text = request.Text;
            blog.ImageUrl = request.ImgUrl;
            _db.BlogPosts.Update(blog);
            _db.SaveChanges();
            return Ok(blog);
        }
		[HttpPost]
        public IActionResult Create(CreateBlogRequest request)
        {
            System.Diagnostics.Debug.Print(Request.Body.ToString());
            if (request == null) return NotFound();
            var blog = new BlogPost();
            blog.Text = request.Text;
            blog.ImageUrl = request.ImgUrl;
            blog.CreatedAt = DateTime.Now;
            _db.BlogPosts.Add(blog);
            _db.SaveChanges();
            //return 201
            return CreatedAtAction(
                actionName: nameof(Get),
                routeValues: new { id = blog.Id },
                value: request
            );
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            // get blog
            
            BlogPost blog = _db.BlogPosts.Find(id);
            if(blog == null)
            {
                return NotFound();
            }
            // return 200
            return Ok(
                blog
            );
        }

        [HttpGet]
        public async Task<ActionResult<List<BlogPost>>> GetBlogPosts()
        {
            return (await _db.BlogPosts.ToListAsync()).OrderByDescending(s => s.CreatedAt).ToList();
        }

        public record CreateBlogRequest(
            string Text,
            string ImgUrl
        );

	}
}
