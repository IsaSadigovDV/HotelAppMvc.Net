using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class ServiceController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return Json("ok");
        }
    }
}
