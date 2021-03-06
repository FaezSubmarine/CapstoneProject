// <auto-generated />
using System;
using CapstoneProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapstoneProject.Migrations
{
    [DbContext(typeof(RaceContext))]
    [Migration("20210625014033_hopefullyfinal")]
    partial class hopefullyfinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Identity")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CapstoneProject.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UsernameChangeLimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "360c9255-6fac-45a2-b2d2-369bd6f2f004",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Sam",
                            LastName = "Specialman",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEOmBctqzEkj9yAwviIQ7+129zsOasGyl0EqhMlgdBiR3pcWPiZMBBwCy343LVa4vg==",
                            PhoneNumber = "801-222-2201",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "4aa28951-46f2-49c9-93ac-c1ece419a0ed",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com",
                            UsernameChangeLimit = 10
                        },
                        new
                        {
                            Id = "b742dd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f171bbaa-a12c-4b04-876d-88efbbc72e04",
                            Email = "mod@hotmail.com",
                            EmailConfirmed = true,
                            FirstName = "Max",
                            LastName = "modman",
                            LockoutEnabled = false,
                            NormalizedEmail = "mod@hotmail.com",
                            NormalizedUserName = "mod@hotmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEFwoHHCUWggX5UR9PtKhjS1cvbDgPzFtAnN9xjHWweC6sGSVLqCUXho+HcDe5p4+3A==",
                            PhoneNumber = "801-123-2201",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "19a0fa15-603e-4c37-ac8f-f32795436ec9",
                            TwoFactorEnabled = false,
                            UserName = "mod@hotmail.com",
                            UsernameChangeLimit = 10
                        },
                        new
                        {
                            Id = "b74dd234-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0cfe5959-7084-4144-84ba-f77f3704cd1a",
                            Email = "user@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Brax",
                            LastName = "userman",
                            LockoutEnabled = false,
                            NormalizedEmail = "user@gmail.com",
                            NormalizedUserName = "user@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEjRIdcxYlClo7e6czjDDsz9mTE20YYwKVO5vdg7869XuFEWYFnsK7Bcxgs5MBAOJw==",
                            PhoneNumber = "801-222-2222",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "34301201-d244-440e-af1e-6af6244d0c38",
                            TwoFactorEnabled = false,
                            UserName = "user@gmail.com",
                            UsernameChangeLimit = 10
                        });
                });

            modelBuilder.Entity("CapstoneProject.Models.RaceRecords", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("carName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("circuitID")
                        .HasColumnType("int");

                    b.Property<string>("timing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usernameID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("circuitID");

                    b.ToTable("raceRecordLists");

                    b.HasData(
                        new
                        {
                            id = 1,
                            carName = "Mazda-MX5",
                            circuitID = 1,
                            timing = "2m20s",
                            usernameID = "b74dd234-6340-4840-95c2-db12554843e5"
                        });
                });

            modelBuilder.Entity("CapstoneProject.Models.circuit", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("circuitList");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "Sepang"
                        },
                        new
                        {
                            id = 2,
                            name = "Portimao"
                        },
                        new
                        {
                            id = 3,
                            name = "Silverstone"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "c7b01222-5201-4317-abd8-c211f91b7330",
                            ConcurrencyStamp = "2",
                            Name = "Mod",
                            NormalizedName = "Mod"
                        },
                        new
                        {
                            Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                            ConcurrencyStamp = "3",
                            Name = "User",
                            NormalizedName = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "b742dd14-6340-4840-95c2-db12554843e5",
                            RoleId = "c7b01222-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "b74dd234-6340-4840-95c2-db12554843e5",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("CapstoneProject.Models.RaceRequest", b =>
                {
                    b.HasBaseType("CapstoneProject.Models.RaceRecords");

                    b.Property<DateTime>("dayOfArrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("declineReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("requestStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("timeOfArrival")
                        .HasColumnType("datetime2");

                    b.ToTable("raceRequestLists");
                });

            modelBuilder.Entity("CapstoneProject.Models.RaceRecords", b =>
                {
                    b.HasOne("CapstoneProject.Models.circuit", "circuit")
                        .WithMany()
                        .HasForeignKey("circuitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("circuit");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CapstoneProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CapstoneProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapstoneProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CapstoneProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CapstoneProject.Models.RaceRequest", b =>
                {
                    b.HasOne("CapstoneProject.Models.RaceRecords", null)
                        .WithOne()
                        .HasForeignKey("CapstoneProject.Models.RaceRequest", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
