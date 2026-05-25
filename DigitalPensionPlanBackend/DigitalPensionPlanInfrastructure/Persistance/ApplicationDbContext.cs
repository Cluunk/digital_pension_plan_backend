using DigitalPensionPlanDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigitalPensionPlanInfrastructure.Persistance
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<AgeGroup> AgeGroups { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
