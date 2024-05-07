using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
