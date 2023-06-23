using HotelApp.Models;

namespace HotelApp.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public Setting? Setting { get; set; }    
    }
}
