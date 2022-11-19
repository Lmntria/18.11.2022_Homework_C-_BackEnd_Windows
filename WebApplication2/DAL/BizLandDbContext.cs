using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2.DAL
{
    public class BizLandDbContext:DbContext
    {
        public BizLandDbContext(DbContextOptions<BizLandDbContext> options):base(options)
        {

        }


        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Tests { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Prices> Prices { get; set; }
    }
}
