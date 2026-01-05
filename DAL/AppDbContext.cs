using BookSawNew.Models;
using Microsoft.EntityFrameworkCore;

namespace BookSawNew.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }


    }
}
