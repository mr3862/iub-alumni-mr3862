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
            //seed data
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = Utility.Roles.SuperAdmin.ToString() },
                new IdentityRole { Name = Utility.Roles.Admin.ToString() },
                new IdentityRole { Name = Utility.Roles.Basic.ToString() }
                );
        }
        public virtual DbSet<Profile> Profiles { get; set; }

    }
}