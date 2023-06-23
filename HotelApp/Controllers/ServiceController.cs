using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class ServiceController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
