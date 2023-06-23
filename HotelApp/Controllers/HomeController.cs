using HotelApp.Context;
using HotelApp.Models;
using HotelApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelApp.Controllers
{
    public class  HomeController: Controller
    {
        private readonly HotelAppDbContext _context;

        public HomeController(HotelAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Slides
                               .Where(x => !x.IsDeleted)
                                    .ToList();
            homeVM.Setting = _context.Settings.FirstOrDefault();
            return View(homeVM);
        }
        #region CreateSlider
        //public async Task<IActionResult> Create()
        //{
        //    Slider slider = new Slider()
        //    {
        //        CreatedDate= DateTime.UtcNow.AddHours(4),
        //        IsDeleted = false,
        //        Title = "Jesus World",
        //        Link = "https://www.facebook.com/",
        //        Image = "carousel-1.jpg"
        //    };

        //    Slider slider2 = new Slider()
        //    {
        //        CreatedDate = DateTime.UtcNow.AddHours(4),
        //        IsDeleted = false,
        //        Title = "Land of Jesus",
        //        Link = "https://www.instagram.com/",
        //        Image = "carousel-2.jpg"
        //    };
        //    await _context.AddAsync(slider);
        //    await _context.AddAsync(slider2);
        //    await _context.SaveChangesAsync();
        //    return Json("ok");
        //}
        #endregion
        #region CreateSetting
        //public async Task<IActionResult> CreateSetting()
        //{
        //    Setting setting = new Setting()
        //    {
        //        Email = "example@example.com",
        //        PhoneNumber = "1234567890",
        //        Address = "123 Main Street",
        //        AboutText = "This is the about text.",
        //        RoomCount = 10,
        //        StaffCount = 5,
        //        ClientCount = 100,
        //        DiscoverTitle = "Discover Title",
        //        DiscoverDesc = "Discover description.",
        //        VideoLink = "https://example.com/video",
        //        CreatedDate = DateTime.UtcNow.AddHours(4)
        //    };
        //    await _context.AddAsync(setting);
        //    await _context.SaveChangesAsync();
        //    return Json("ok");
        //}
        #endregion


    }
}