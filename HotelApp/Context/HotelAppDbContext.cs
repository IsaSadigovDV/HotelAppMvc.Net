using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore;
using HotelApp.Models;

namespace HotelApp.Context

{
    public class HotelAppDbContext:DbContext
    {
        public DbSet<Slider> Slides { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public HotelAppDbContext(DbContextOptions<HotelAppDbContext> options) : base(options)
        {   

        }
    }
}
