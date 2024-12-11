
using Calories_Calculator.Data;
using Microsoft.EntityFrameworkCore;

namespace Calories_Calculator.Models
    {
    public class FoodService
    {
        private readonly ApplicationDbContext _context;

        public FoodService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Food> GetAll()
        {
            return _context.Foods; // Return IQueryable for deferred execution
        }

        public Food GetById(int id)
        {
            return _context.Foods.FirstOrDefault(f => f.Id == id);
        }

        public void AddFood(Food food)
        {
            
            _context.Foods.Add(food);
            _context.SaveChanges();
        }
        public void DeleteFood(Food food)
        {
            _context.Foods.Remove(food);
            _context.SaveChanges();
        }
        
        
    }

    }


