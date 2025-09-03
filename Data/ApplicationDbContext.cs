using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Underwriting.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData
            (
                new ApplicationUser
                {
                    Id = "61d470129b42b0f4965aad74",
                    UserName = "asmith@i3verticals.com",
                    NormalizedUserName = "asmith@i3verticals.com",
                    Email = "asmith@i3verticals.com",
                    NormalizedEmail = "ASMITH@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Alyssa Smith",
                },
                new ApplicationUser
                {
                    Id = "62420940457e21a2ca768c79",
                    UserName = "astovallhardy@i3verticals.com",
                    NormalizedUserName = "astovallhardy@i3verticals.com",
                    Email = "astovallhardy@i3verticals.com",
                    NormalizedEmail = "ASTOVALLHARDY@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Angela Hardy",
                },
                new ApplicationUser
                {
                    Id = "5d4a2dfdcd49961c2cd5729f",
                    UserName = "benji.lamfers@i3verticals.com",
                    NormalizedUserName = "benji.lamfers@i3verticals.com",
                    Email = "benji.lamfers@i3verticals.com",
                    NormalizedEmail = "BENJI.LAMFERS@I3VERTICALS.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Benji Lamfers",
                },
                new ApplicationUser
                {
                    Id = "58574246aa45842a200103db",
                    UserName = "dfonseca@i3verticals.com",
                    NormalizedUserName = "dfonseca@i3verticals.com",
                    Email = "dfonseca@i3verticals.com",
                    NormalizedEmail = "DFONSECA@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Daniel Fonseca",
                },
                new ApplicationUser
                {
                    Id = "585742f4aa45842a200193b2",
                    UserName = "justin.esber@payschools.com",
                    NormalizedUserName = "justin.esber@payschools.com",
                    Email = "justin.esber@payschools.com",
                    NormalizedEmail = "JUSTIN.ESBER@PAYSCHOOLS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Justin Esber",
                },
                new ApplicationUser
                {
                    Id = "59691d964b9cfc16a848e768",
                    UserName = "dsowiak@i3verticals.com",
                    NormalizedUserName = "DSOWIAK@I3VERTICALS.COM",
                    Email = "dsowiak@i3verticals.com",
                    NormalizedEmail = "DSOWIAK@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "David Sowiak",
                },
                new ApplicationUser
                {
                    Id = "58574197aa45842a20007798",
                    UserName = "lreedy@gmail.com",
                    NormalizedUserName = "lreedy@gmail.com",
                    Email = "lreedy@gmail.com",
                    NormalizedEmail = "LREEDY@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Lisa Reedy",
                },
                new ApplicationUser
                {
                    Id = "597b2d274b9cfc2e6c819088",
                    UserName = "tee.locke@neo.rr.com",
                    NormalizedUserName = "tee.locke@neo.rr.com",
                    Email = "tee.locke@neo.rr.com",
                    NormalizedEmail = "TEE.LOCKE@NEO.RR.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Tee Locke",
                },
                new ApplicationUser
                {
                    Id = "620bd70caf64c4562d58b84c",
                    UserName = "czarnke@i3verticals.com",
                    NormalizedUserName = "czarnke@i3verticals.com",
                    Email = "czarnke@i3verticals.com",
                    NormalizedEmail = "CZARNKE@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Christian Zarnke",
                },
                new ApplicationUser
                {
                    Id = "63a249ee424c29d968059d8d",
                    UserName = "Sysadmin@i3Verticals.com",
                    NormalizedUserName = "Sysadmin@i3Verticals.com",
                    Email = "Sysadmin@i3Verticals.com",
                    NormalizedEmail = "SYSADMIN@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Sys Admin",
                },
                new ApplicationUser
                {
                    Id = "636c2737b81806331e91f99e",
                    UserName = "vsisk@i3verticals.com",
                    NormalizedUserName = "vsisk@i3verticals.com",
                    Email = "vsisk@i3verticals.com",
                    NormalizedEmail = "VSISK@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Vadeene Sisk",
                },
                new ApplicationUser
                {
                    Id = "63b6ec7733247bfd8698d629",
                    UserName = "crumsey@i3verticals.com",
                    NormalizedUserName = "crumsey@i3verticals.com",
                    Email = "crumsey@i3verticals.com",
                    NormalizedEmail = "CRUMSEY@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Colleen Rumsey",
                },
                new ApplicationUser
                {
                    Id = "63740329467a12cd1cf74e41",
                    UserName = "sridinger@i3verticals.com",
                    NormalizedUserName = "sridinger@i3verticals.com",
                    Email = "sridinger@i3verticals.com",
                    NormalizedEmail = "SRIDINGER@I3VERTICALS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test@123"),
                    SecurityStamp = string.Empty,
                    DisplayName = "Sonya Ridinger",
                }
            );

            // Seed roles 
            builder.Entity<IdentityRole>().HasData
            (
                new IdentityRole
                {
                    Id = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    Name = "Underwriter",
                    NormalizedName = "UNDERWRITER"
                },
                new IdentityRole
                {
                    Id = "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a",
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData
            (
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "61d470129b42b0f4965aad74"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "62420940457e21a2ca768c79"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "5d4a2dfdcd49961c2cd5729f"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "58574246aa45842a200103db"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "59691d964b9cfc16a848e768"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "585742f4aa45842a200193b2"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "58574197aa45842a20007798"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "597b2d274b9cfc2e6c819088"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a",
                    UserId = "63740329467a12cd1cf74e41"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f",
                    UserId = "620bd70caf64c4562d58b84c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a",
                    UserId = "636c2737b81806331e91f99e"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a",
                    UserId = "63b6ec7733247bfd8698d629"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a",
                    UserId = "63a249ee424c29d968059d8d"
                }
            );
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
