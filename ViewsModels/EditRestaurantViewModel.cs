using System.ComponentModel.DataAnnotations;
using Restaurant.Models;

namespace Restaurant.ViewsModels
{
    public class EditRestaurantViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}