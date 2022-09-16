using LaptopsOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace LaptopsOnline.Data
{
    public class LaptopsOnlineDbContex :DbContext
    {
        public LaptopsOnlineDbContex(DbContextOptions options) : base(options)  
        {

        }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
