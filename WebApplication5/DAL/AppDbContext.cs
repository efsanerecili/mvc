using Microsoft.EntityFrameworkCore;
using WebApplication5.Controllers;

namespace WebApplication5.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<HomeController> HomeControllers { get; set; }
    }
}
