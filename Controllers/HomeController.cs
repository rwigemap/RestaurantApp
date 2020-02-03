using System;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Services;
using Restaurant.ViewsModels;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantAll _restaurantAll;

        public HomeController(IRestaurantAll restaurantAll)
        {
            _restaurantAll = restaurantAll;
        }
        // GET
        public IActionResult Index()
        {
            // var resto = new Restaurant{Id = 1, Name = "Meze Fresh"};
            //var resto = _restaurantData.GetAll();
            var resto = new HomeViewModel();
            resto.Restaurants = _restaurantAll.GetAll();
            return View(resto);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(EditRestaurantViewModel model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = new Models.Restaurant {Name = model.Name, Cuisine = model.Cuisine};
                _restaurantAll.Add(restaurant);

                // return View("Details", restaurant);

                return RedirectToAction("Details", new {id = restaurant.Id}); // TODO :fix redirection to details

            }

            return View();
        }
        
        
        

        public IActionResult Details(int id)
        {
            var resto = _restaurantAll.Get(id);

            if (resto == null)
            {
                return RedirectToAction("Index");
            }

            return View(resto);
        }

        public IActionResult Delete(int id)
        {
            var resto = _restaurantAll.Get(id);
            
            if (ModelState.IsValid)
            {
                _restaurantAll.Delete(id);
                return RedirectToAction("Index", "Home"); // TODO :fix redirection to details
            }

            if (resto == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        
        public IActionResult Edit(int id,Models.Restaurant restaurant)
        {
            var resto = _restaurantAll.Get(id);
            if (resto == null)
            {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                var r = new Models.Restaurant
                {
                    Id = id,
                    Name = restaurant.Name,
                    Cuisine = restaurant.Cuisine

                };
                _restaurantAll.Update(id,r);
                
            }
            
            return View(resto);
        }
    }
}