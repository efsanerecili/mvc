using Microsoft.AspNetCore.Mvc;
using WebApplication5.DAL;


namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext dbContext;
        public HomeController(AppDbContext dbContext) { 
        }

        public IActionResult Index()
        {
          
            return View();
        }
    }
}
