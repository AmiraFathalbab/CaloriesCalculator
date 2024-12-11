using Calories_Calculator.Data;
using Microsoft.EntityFrameworkCore;
namespace Calories_Calculator.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Calory { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = default!;
        //ApplicationDbContext context = new ApplicationDbContext();
        //public DbSet<Food> GetAll()
        //{
            
        //    return context.Foods;
        //}
        //public Food GetById(int Id)
        //{
        //    return context.Foods.FirstOrDefault(f => f.Id == Id);
        //}



    }
}
