using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace petAdoptionApi.Models.Start_Model
{
    public class PetAdoptionContext: DbContext
    {
        private readonly IConfiguration _config;
        private readonly ILogger<PetAdoptionContext> _logger;

        public PetAdoptionContext(IConfiguration IConfig, ILogger<PetAdoptionContext> logger)
        {
            _config = IConfig;
            _logger = logger;
            _logger.LogInformation("Class conxtext constructor initiated properly");
        }

        public DbSet<Pet> pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString: _config.GetConnectionString("PetAdoptionDB") ?? "");
            _logger.LogInformation("Configuration database made!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Freddy",
                    Breed = "SRD"
                },
                new Pet
                {
                    Id = 2,
                    Name = "Jaja",
                    Breed = "Tigrado"
                }, new Pet
                {
                    Id = 3,
                    Name = "Murphy",
                    Breed = "Frajola"
                }, new Pet
                {
                    Id = 4,
                    Name = "Hermione",
                    Breed = "Laranja"
                }, new Pet
                {
                    Id = 5,
                    Name = "Faraday",
                    Breed = "Frajola"
                }
            );
        }
    }
}
