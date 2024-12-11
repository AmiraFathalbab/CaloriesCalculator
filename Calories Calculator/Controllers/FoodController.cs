using Microsoft.AspNetCore.Mvc;
//using Calories_Calculator.Data;
using Calories_Calculator.Models;
using System.Dynamic;
//using Microsoft.EntityFrameworkCore;

namespace Calories_Calculator.Controllers
{
    public class FoodController : Controller
    {


        private readonly FoodService _foodService;

        // Inject FoodService instead of ApplicationDbContext
        public FoodController(FoodService foodService)
        {
            _foodService = foodService;
        }

        public IActionResult ShowAll()
        {
            // Use FoodService to retrieve all foods
            return View(_foodService.GetAll().ToList());
        }

        public IActionResult AddNew()
        {
            dynamic mymodel = new ExpandoObject();
            
            return View(mymodel);
        }

        //[HttpPost] // Add this attribute to indicate that this action handles POST requests
        public IActionResult SaveNew(Food food,Department department)
        {
            if (!string.IsNullOrWhiteSpace(food.Name)) // Check if the name is not null or empty
            {
                
                food.DepartmentId =department.Id;
                _foodService.AddFood(food); // Use the service to add the food
            }
            return RedirectToAction("ShowAll");
        }

        public IActionResult Delete(int id)
        {
            var _food = _foodService.GetById(id);
            _foodService.DeleteFood(_food);
            return RedirectToAction("ShowAll");
        }
    }
}
//public IActionResult SaveNew(Food food)
//{
//    if (food.Name != null)
//    {
//        _context.Foods.Add(food);
//        _context.SaveChanges();
//    }
//    return RedirectToAction("ShowAll");
//}