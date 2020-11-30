using Microsoft.EntityFrameworkCore;
using BlogApi.Models;

namespace BlogApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<User> Users { get; set; }
    }

}