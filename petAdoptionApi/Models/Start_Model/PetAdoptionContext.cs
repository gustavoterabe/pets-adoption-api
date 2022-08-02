using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace petAdoptionApi.Models.Start_Model
{
    public class PetAdoptionContext: DbContext
    {
        private readonly IConfiguration _config;
        private readonly ILogger<PetAdoptionContext> _logger;

        public PetAdoptionContext() { }
        

        public PetAdoptionContext(IConfiguration IConfig, ILogger<PetAdoptionContext> logger)
        {
            _config = IConfig;
            _logger = logger;
            _logger.LogDebug("Start Conxtext");
        }

        public DbSet<Pet> pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //_logger.LogDebug("It was started");
            optionsBuilder.UseNpgsql(connectionString: "Host=localhost;Port=5432;User Id=root;Password=admin;Database=petDb");
        }
    }
}
