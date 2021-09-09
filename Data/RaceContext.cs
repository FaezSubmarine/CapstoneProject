using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CapstoneProject.Data
{
    public class RaceContext: IdentityDbContext<ApplicationUser>
    {
        public RaceContext(DbContextOptions<RaceContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData.Seed(modelBuilder);
            modelBuilder.HasDefaultSchema("Identity");

            modelBuilder.Entity<RaceRequest>(entity =>
            {
                entity.Property(e => e.requestStatus).HasMaxLength(50).HasConversion(x => x.ToString(), x => (RequestStatus)Enum.Parse(typeof(RequestStatus), x));
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");

            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RaceStore;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<RaceRecords> raceRecordLists { get; set; }
        public DbSet<RaceRequest> raceRequestLists { get; set; }

        public DbSet<circuit> circuitList { get; set; }
    }
}
