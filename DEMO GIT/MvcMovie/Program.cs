
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

var builder = WebApplication.CreateBuilder(args);
 builder.Services.AddDbContext<ApplicationDbcontext>(options=>
 options.UseSqlite(builder.Configuration.GetConnectionString("DefautConnection")
 ?? throw new InvalidOperationException("Connecttion string' DefautConnection'not found'")));
 // add services to the container
 builder.Services.AddControllersWithViews();
 var app = builder.Build();
 

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();