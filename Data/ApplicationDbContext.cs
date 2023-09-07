using IUBAlumniUSA.Models;
using IUBAlumniUSA.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace IUBAlumniUSA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

            //Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());


            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seed data

            var roleId = "1";// "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1";
            var userId = "1";//"ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2";
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = roleId, Name = Utility.Roles.SuperAdmin.ToString(),NormalizedName = Utility.Roles.SuperAdmin.ToString().ToUpper() },
                new IdentityRole { Name = Utility.Roles.Admin.ToString(), NormalizedName = Utility.Roles.Admin.ToString().ToUpper() },
                new IdentityRole { Name = Utility.Roles.Basic.ToString(), NormalizedName = Utility.Roles.Basic.ToString().ToUpper() }
                );

            var supUser = new IdentityUser
            {
                Id = userId,
                UserName = "SuperAdmin@aaina.org",
                NormalizedUserName = "SUPERADMIN@AAINA.ORG",
                Email = "SuperAdmin@aaina.org",
                NormalizedEmail = "SUPERADMIN@AAINA.ORG",
                EmailConfirmed = true
            };
            var hasher = new PasswordHasher<IdentityUser>();
            supUser.PasswordHash = hasher.HashPassword(supUser, "Password_1");
            builder.Entity<IdentityUser>().HasData(supUser);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = userId, RoleId = roleId });

        }
        public virtual DbSet<Profile> Profiles { get; set; }

    }
}