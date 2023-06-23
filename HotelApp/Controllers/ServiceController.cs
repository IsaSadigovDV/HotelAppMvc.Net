using HotelApp.Context;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly HotelAppDbContext _context;

        public ServiceController(HotelAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {

            Service service = new Service() 
            {
                CreatedDate = DateTime.UtcNow.AddHours(4),
                Description = "This is service description that genereted from database",
                   Icon = "<i class='fa fa-hotel fa-2x text-primary'></i>",
                   Link = "https://github.com/IsaSadigovDV/HotelAppMvc.Net",
            };

            Service service2 = new Service()
            {
                CreatedDate = DateTime.UtcNow.AddHours(4),
                Description = "This is service description that genereted from database",
                Icon = "<i class='fa fa-utensils fa-2x text-primary'></i>",
                Link = "https://github.com/IsaSadigovDV/HotelAppMvc.Net",
            };

            Service service3 = new Service()
            {
                CreatedDate = DateTime.UtcNow.AddHours(4),
                Description = "This is service description that genereted from database",
                Icon = "<i class='fa fa-spa fa-2x text-primary'></i>",
                Link = "https://github.com/IsaSadigovDV/HotelAppMvc.Net",
            };
            await _context.AddAsync(service);
            await _context.AddAsync(service2);
            await _context.AddAsync(service3);
            
            await _context.SaveChangesAsync();
            return Json("ok");
        } 
       
    }
}
