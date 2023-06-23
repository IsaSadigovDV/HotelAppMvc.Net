﻿using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Setting:BaseModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string AboutText { get; set; }

        [Required]
        public int RoomCount { get; set; }

        [Required]
        public int StaffCount { get; set; }

        [Required]
        public int ClientCount { get; set; }

        [Required]
        public string DiscoverTitle { get; set; }

        [Required]
        public string DiscoverDesc { get; set; }

        [Required]
        public string VideoLink { get; set; }
    }
}
