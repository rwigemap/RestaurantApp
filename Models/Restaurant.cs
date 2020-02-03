using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public enum CuisineType
    {
        None,
        African,
        Italian,
        Indian,
        Mexican
    }
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, MaxLength(80)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}