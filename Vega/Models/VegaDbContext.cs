using Microsoft.EntityFrameworkCore;

namespace Vega.Models
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {

        }

        public DbSet<Model> Models { get; set; }
    }
}