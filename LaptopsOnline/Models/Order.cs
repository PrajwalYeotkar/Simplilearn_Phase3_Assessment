using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace LaptopsOnline.Models
{
    public class Order
	{
        public int Id { get; set; }


        public int LaptopId { get; set; }

        [Required(ErrorMessage = "Client Name is required")]
        public string? ClientName { get; set; }


        public string? Street { get; set; }

        [Required(ErrorMessage = "City Name is required")]
        public string? City { get; set; }
        [Required(ErrorMessage = "State Name is required")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Country Name is required")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "Zip  is required")]
        
        public string? Zip { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string? Phone { get; set; }


        public string? Email { get; set; }


    }
}
