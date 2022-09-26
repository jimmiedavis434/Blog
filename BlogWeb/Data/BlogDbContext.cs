using BlogWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWeb.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
        public DbSet<Blog> blogs { get; set; }
    }
}
