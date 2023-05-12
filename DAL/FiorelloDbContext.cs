using Fiorello.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.DAL
{
    public class FiorelloDbContext:DbContext
    {
        public FiorelloDbContext(DbContextOptions<FiorelloDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Catagory> catagories { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Setting> settings { get; set; }
    }
}
