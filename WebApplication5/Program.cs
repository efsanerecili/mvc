using Microsoft.EntityFrameworkCore;
using WebApplication5.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("Server=.;database=bb207_firstWeb; Trusted_connection=true; Integrated security=true; Encrypt=false");
});
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.Run();

