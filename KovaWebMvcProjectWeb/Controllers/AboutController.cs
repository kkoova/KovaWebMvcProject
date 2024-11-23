using Microsoft.AspNetCore.Mvc;

namespace KovaWebMvcProjectWeb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
