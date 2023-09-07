using IUBAlumniUSA.Data;
using IUBAlumniUSA.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using UBAlumniUSA.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

//builder.Services.AddControllersWithViews().AddRazorPagesOptions(options =>
//{
//    options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "");
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); 

app.Run();



/*
 In Visual Studio, you can use the Package Manager Console to apply pending migrations to the database:
PM> Add-Migration Initial
PM> Update-Database

OR
EntityFrameworkCore\Add-Migration Initial
EntityFrameworkCore\Update-Database

Alternatively, you can apply pending migrations from a command prompt at your project directory:

> dotnet ef database update

To Remove DB
Drop-Database
remove-migration -force


Add-Migration profile123
Update-Database
 */