using IUBAlumniUSA.Models;
using IUBAlumniUSA.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;


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


        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<SysConfig> SysConfigs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seed data

           // var roleId = "1";// "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1";
            var userId = "1";//"ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2";
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = Utility.Roles.SuperAdmin.ToString(), NormalizedName = Utility.Roles.SuperAdmin.ToString().ToUpper() },
                new IdentityRole { Id = "2", Name = Utility.Roles.Admin.ToString(), NormalizedName = Utility.Roles.Admin.ToString().ToUpper() },
                new IdentityRole { Id = "3", Name = Utility.Roles.Basic.ToString(), NormalizedName = Utility.Roles.Basic.ToString().ToUpper() }
                );

            var supUser = new IdentityUser
            {
                Id = userId,
                UserName = "mr3862@columbia.edu",
                NormalizedUserName = "MR3862@COLUMBIA.EDU",
                Email = "mr3862@columbia.edu",
                NormalizedEmail = "MR3862@COLUMBIA.EDU",
                EmailConfirmed = true
            };
            var hasher = new PasswordHasher<IdentityUser>();
            supUser.PasswordHash = hasher.HashPassword(supUser, "Password_1");
            builder.Entity<IdentityUser>().HasData(supUser);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = userId, RoleId = "1" },
                new IdentityUserRole<string> { UserId = userId, RoleId = "2" }
                );

            var prof = new Profile
            {
                Id = 1,
                FirstName = "Super",
                LastName = "Admin",
                BatchYear = 1993,
                // Degree = "N/A",
                IsApproved = true,
                // Address = "N/A",
                // City = "N/A",
                // Country = "USA",
                // ProvinceState = "N/A",
                // ZipPostalCode = "NA",
                //// ProfilePicture =null,
                IdentityUserId = userId
            };
            builder.Entity<Profile>().HasData(prof);

            // builder.Entity<Degree>().HasKey(e => e.Id).HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);
           // builder.Entity<Degree>()     .Property(x => x.Id)     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            builder.Entity<Degree>().HasData(
                new Degree { Id = 1,  DegreeName = "B.Sc. in Computer Science", DegreeLevel = "B" },
                new Degree { Id = 2, DegreeName = "B.Sc. in Electrical & Electronic Engineering", DegreeLevel = "B" },
                new Degree { Id = 3, DegreeName = "B.Sc. in Electrical & Telecommunication Engineering", DegreeLevel = "B" },
                new Degree { Id = 4, DegreeName = "B.Sc. in Computer Science & Engineering", DegreeLevel = "B" },
                new Degree { Id = 5, DegreeName = "B.Sc. in Pharmacy", DegreeLevel = "B" },
                new Degree { Id = 6, DegreeName = "Bachelor of Business Administration", DegreeLevel = "B" },
                new Degree { Id = 7, DegreeName = "M.Sc. in Computer Science", DegreeLevel = "M" },
                new Degree { Id = 8, DegreeName = "M.Sc. in Software Engineering", DegreeLevel = "M" },
                new Degree { Id = 9, DegreeName = "M.Sc. in  Computer Networks and Communications", DegreeLevel = "M" },
                new Degree { Id = 10, DegreeName = "M.Sc. in Telecommunication Engineering", DegreeLevel = "M" },
                new Degree { Id = 11, DegreeName = "Master of Business Administration", DegreeLevel = "M" }
                /*
                insert into[dbo].[Degrees](DegreeName, DegreeLevel)
values('B.Sc. in Electrical & Telecommunication Engineering', 'B'),
                ('B.Sc. in Computer Science & Engineering', 'B'),
               ('B.Sc. in Pharmacy', 'B'),
                ('Bachelor of Business Administration', 'B'),
                ('M.Sc. in Computer Science', 'M'),
                ('M.Sc. in Software Engineering', 'M'),
                ('M.Sc. in  Computer Networks and Communications', 'M'),
                ('M.Sc. in Telecommunication Engineering', 'M'),
                ('Master of Business Administration', 'M')*/
            );


            builder.Entity<SysConfig>().HasData(
                new SysConfig { Id = 1, Key = "EmailSender", Value = "mr3862@columbia.edu", Type = "Basic", CreateUser = "System", CreateTS = DateTime.Now },
                new SysConfig { Id = 2, Key = "EmailSenderName", Value = "IUB Alumni - North America", Type = "Basic", CreateUser = "System", CreateTS = DateTime.Now }
                
                );
        }



    }
}