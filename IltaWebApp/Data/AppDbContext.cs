using IltaWebApp.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IltaWebApp.Data;


public class AppDbContext : DbContext
{
        
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAccount>().HasData(
            new UserAccount() { Id=1, UserName="Admin", Password="password", Role="Administrator"}

        );
       
    }
}




