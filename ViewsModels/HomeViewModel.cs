using System.Collections.Generic;

namespace Restaurant.ViewsModels
{
    public class HomeViewModel
    {
        public IEnumerable<Models.Restaurant> Restaurants { get; set; }
    }
}