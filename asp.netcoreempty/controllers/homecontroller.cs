using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        // Index Action
        public IActionResult Index()
        {
            return View(); // View döndürülüyor
        }
    }
}
