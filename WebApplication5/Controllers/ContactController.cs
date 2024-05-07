using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
