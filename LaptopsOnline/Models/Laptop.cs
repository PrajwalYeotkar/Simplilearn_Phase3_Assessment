using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace LaptopsOnline.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ModelName is required")]
        public string? ModelName { get; set; }
        public string? Price { get; set; }
        public string? Image { get; set; }
        public string? Brand { get; set; }
        public string? RamSize { get; set; }
        public string? CPUModel { get; set; }
        public string? ScreenSize { get; set; }
        public string? Description { get; set; }

    }
}
