using CapstoneProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneProject.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<circuit>().HasData(
                new circuit
                {
                    id = 1,
                    name = "Sepang"
                },
                new circuit
                {
                    id = 2,
                    name = "Portimao"
                },
                new circuit
                {
                    id = 3,
                    name = "Silverstone"
                }
            );
            modelBuilder.Entity<RaceRequest>().HasData(
                new RaceRequest
                {
                    id = 1,
                    usernameID = "b74dd234-6340-4840-95c2-db12554843e5",
                    circuitID = 1,
                    carName = "Mazda-MX5",
                    timing = "2m20s",
                    dayOfArrival = DateTime.MinValue,
                    timeOfArrival = DateTime.MinValue,

                }
            );

            IdentityUser u = new IdentityUser();

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            ApplicationUser user = new ApplicationUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                FirstName = "Sam",
                LastName = "Specialman",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                PasswordHash = passwordHasher.HashPassword(u, "Testing123"),
                PhoneNumber = "801-222-2201",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            IdentityUser u2 = new IdentityUser();

            passwordHasher = new PasswordHasher<IdentityUser>();
            ApplicationUser user2 = new ApplicationUser()
            {
                Id = "b742dd14-6340-4840-95c2-db12554843e5",
                UserName = "mod@hotmail.com",
                NormalizedUserName = "mod@hotmail.com",
                FirstName = "Max",
                LastName = "modman",
                Email = "mod@hotmail.com",
                NormalizedEmail = "mod@hotmail.com",
                PasswordHash = passwordHasher.HashPassword(u2, "Testing321"),
                PhoneNumber = "801-123-2201",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            IdentityUser u3 = new IdentityUser();

            passwordHasher = new PasswordHasher<IdentityUser>();
            ApplicationUser user3 = new ApplicationUser()
            {
                Id = "b74dd234-6340-4840-95c2-db12554843e5",
                UserName = "user@gmail.com",
                NormalizedUserName = "user@gmail.com",
                FirstName = "Brax",
                LastName = "userman",
                Email = "user@gmail.com",
                NormalizedEmail = "user@gmail.com",
                PasswordHash = passwordHasher.HashPassword(u3, "Testing231"),
                PhoneNumber = "801-222-2222",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            //string password =  passwordHasher.HashPassword(user, "admin123");
            //user.PasswordHash = password;

            modelBuilder.Entity<ApplicationUser>().HasData(user,user2,user3);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b01222-5201-4317-abd8-c211f91b7330", Name = "Mod", ConcurrencyStamp = "2", NormalizedName = "Mod" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "User", ConcurrencyStamp = "3", NormalizedName = "User" }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "c7b01222-5201-4317-abd8-c211f91b7330", UserId = "b742dd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "b74dd234-6340-4840-95c2-db12554843e5" }
                );
        }
    }
}
