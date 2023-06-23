using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class RoomController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
