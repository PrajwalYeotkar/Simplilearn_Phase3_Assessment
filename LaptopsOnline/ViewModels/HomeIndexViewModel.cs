using LaptopsOnline.Models;

namespace LaptopsOnline.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Laptop> Laptops { get; set; }   
        public IEnumerable<Carousel> Carousels { get; set; }   
    }
}
