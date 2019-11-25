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
        }

        void ConfigureModelBuilderForBusiness(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>().ToTable("Business");
        }

        void ConfigureModelBuilderForBusinessOperatingHours(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessOperatingHours>().ToTable("BusinessOperatingHours");

            modelBuilder.Entity<BusinessOperatingHours>()
                .HasOne(s => s.Business)
                .WithMany(u => u.OperatingHours)
                .HasForeignKey(s => s.BusinessId);
        }

        void ConfigureModelBuilderForBusinessOwner(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessOwner>().ToTable("BusinessOwner");

            modelBuilder.Entity<BusinessOwner>()
                .HasOne(s => s.Business)
                .WithOne(u => u.BusinessOwner)
                .HasForeignKey("BusinessId");
        }

        void ConfigureModelBuilderForBusinessCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessCategory>().ToTable("BusinessCategory");

            modelBuilder.Entity<BusinessCategory>()
                .HasOne(s => s.Business)
                .WithOne(u => u.BusinessCategory)
                .HasForeignKey("BusinessId");

            modelBuilder.Entity<BusinessCategory>()
                .HasOne(s => s.BusinessType)
                .WithOne(u => u.BusinessCategory)
                .HasForeignKey("BusinessTypeId");
        }

        void ConfigureModelBuilderForBusinessType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessType>().ToTable("BusinessType");
        }

        void ConfigureModelBuilderForStaff(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().ToTable("Staff");

            modelBuilder.Entity<Staff>()
                .HasOne(s => s.Business)
                .WithMany(u => u.Staff)
                .HasForeignKey(s => s.BusinessId);

            //modelBuilder.Entity<Staff>()
            //    .HasOne(s => s.User)
            //    .WithOne(u => u.)
            //    .HasForeignKey("UserId");
        }
    }
}
