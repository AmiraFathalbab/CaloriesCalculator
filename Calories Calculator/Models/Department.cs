using Microsoft.EntityFrameworkCore;

namespace Calories_Calculator.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public List<Food> Foods { get; set; } = new List<Food>();

        //public int GetByName(string name)
        //{
        //    foreach(var dept in Department)
        //    {
        //        if (dept.Name == name)
        //            return dept.Id;
        //    }
        //}
    }
}
