using DOTNETCore3.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DOTNETCore3.Data
{
    public class BusinessPortalContext : DbContext
    {
        public BusinessPortalContext(DbContextOptions options) : base(options) { }

        public DbSet<Business> BusinessDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            ConfigureModelBuilderForUser(modelBuilder);

        }

        void ConfigureModelBuilderForUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>()
                .Property(user => user.FirstName)
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.LastName)
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.Email)
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.Password)
                .IsRequired();
        }

        void ConfigureModelBuilderForBusiness(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>().ToTable("Business");
            modelBuilder.Entity<Business>()
                .Property(s => s.BusinessName)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Business>()
                .HasOne(s => s.BusinessOwner);

            modelBuilder.Entity<Business>()
                    .HasMany(s => s.Staff);

            modelBuilder.Entity<Business>()
                .HasMany(s => s.OperatingHours);
        }

        void ConfigureModelBuilderForBusinessOperatingHours(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>().ToTable("Business");
            modelBuilder.Entity<Business>()
                .Property(s => s.BusinessName)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Business>()
                .HasOne(s => s.BusinessOwner);

            modelBuilder.Entity<Business>()
                    .HasMany(s => s.Staff);

            modelBuilder.Entity<Business>()
                .HasMany(s => s.OperatingHours);
        }
    }
}
