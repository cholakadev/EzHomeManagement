namespace EzHomeManagement.Data
{
    using EzHomeManagement.Data.Configuration;
    using EzHomeManagement.Data.Models.EntityModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Entrance> Entrances { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<UserApartment> UserApartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntranceEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApartmentEntityConfiguration).Assembly);
        }
    }
}
