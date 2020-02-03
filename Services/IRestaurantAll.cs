using System.Collections.Generic;
using System.Linq;
using Restaurant.Models;

namespace Restaurant.Services
{
    public interface IRestaurantAll
    {
        IEnumerable<Models.Restaurant> GetAll();
        Models.Restaurant Get(int id);

        void Add(Models.Restaurant newRestaurant);

        void Delete(int id);
        void Update(int id,Models.Restaurant restaurant);
    }
    //SQLRestaurantData holds the actual implementation of the IRestaurantData Interface of how
    // our data will be stored in the DB
    
    public class SqlRestaurantData : IRestaurantAll
    {
        private readonly RestaurantContext _context;

        public SqlRestaurantData(RestaurantContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.Restaurant> GetAll()
        {
            return  _context.Restaurants.ToList();
        }

        public Models.Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id); 
        }

        public void Add(Models.Restaurant newRestaurant)
        {
            _context.Add(newRestaurant);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Models.Restaurant restaurant;
            restaurant = _context.Restaurants.FirstOrDefault(r => r.Id == id);
            _context.Remove(restaurant);
            _context.SaveChanges();
        }

        public void Update(int id, Models.Restaurant restaurant)
        {
            Models.Restaurant rest;
            rest = _context.Restaurants.FirstOrDefault(r => r.Id == id);
            rest = restaurant;
            _context.Update(rest);
            _context.SaveChanges();
        }
    }
}