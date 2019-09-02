using Microsoft.EntityFrameworkCore;

namespace Vega.Models
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Make>().HasData(
                new Make { Id = 1, Name = "Skoda" },
                new Make { Id = 2, Name = "Opel" },
                new Make { Id = 3, Name = "Audi" },
                new Make { Id = 4, Name = "Toyota" },
                new Make { Id = 5, Name = "Volkswagen" }
            );

            modelBuilder.Entity<Model>().HasData(
                new Model { Id = 1, Name = "Fabia", MakeId = 1 },
                new Model { Id = 2, Name = "Octavia", MakeId = 1 },
                new Model { Id = 3, Name = "Rapid", MakeId = 1 },
                new Model { Id = 4, Name = "Insignia", MakeId = 2 },
                new Model { Id = 5, Name = "Astra", MakeId = 2 },
                new Model { Id = 6, Name = "Corsa", MakeId = 2 },
                new Model { Id = 7, Name = "A4", MakeId = 3 },
                new Model { Id = 8, Name = "A6", MakeId = 3 },
                new Model { Id = 9, Name = "Yaris", MakeId = 4 },
                new Model { Id = 10, Name = "Corolla", MakeId = 4 },
                new Model { Id = 11, Name = "Prius", MakeId = 4 },
                new Model { Id = 12, Name = "Polo", MakeId = 5 },
                new Model { Id = 13, Name = "Golf", MakeId = 5 },
                new Model { Id = 14, Name = "Passat", MakeId = 5 },
                new Model { Id = 15, Name = "Tiguan", MakeId = 5 }
            );

            modelBuilder.Entity<Feature>().HasData(
                new Feature { Id = 1, Name = "Cup holder" },
                new Feature { Id = 2, Name = "Air condition" },
                new Feature { Id = 3, Name = "Heated seats" },
                new Feature { Id = 4, Name = "Automatic transmission" },
                new Feature { Id = 5, Name = "Manual transmission" },
                new Feature { Id = 6, Name = "Navigation" },
                new Feature { Id = 7, Name = "Steel wheels" },
                new Feature { Id = 8, Name = "Alloy wheels" },
                new Feature { Id = 9, Name = "Heated windscreen" }
            );
        }
    }
}