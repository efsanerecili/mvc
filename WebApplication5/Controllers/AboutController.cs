using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
