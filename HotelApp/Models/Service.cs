using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Service:BaseModel
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
