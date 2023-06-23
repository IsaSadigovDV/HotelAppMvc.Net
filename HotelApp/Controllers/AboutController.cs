using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class AboutController : Controller
    {
        public async Task< IActionResult> Index()
        {
            return View();
        }
    }
}
