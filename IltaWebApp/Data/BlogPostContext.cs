using IltaWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace IltaWebApp.Data;


    public class BlogPostContext : DbContext
    {
        public BlogPostContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    
}




