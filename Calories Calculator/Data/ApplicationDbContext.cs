using Microsoft.EntityFrameworkCore;
using Calories_Calculator.Models;
using Microsoft.Extensions.Configuration;
namespace Calories_Calculator.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }
        //public ApplicationDbContext(DbContextOptions options) : base(options)
        //{
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .HasData(new Food[]
                {
                    new Food{ Id = 1,Name="white rice",Image="white rice.jpeg",Calory=140 ,DepartmentId=1},
                    new Food{ Id = 2,Name="brown rice",Image="brown rice.jpg",Calory=135 ,DepartmentId=1},
                    new Food{ Id = 3,Name="beef",Image="beef.jpeg",Calory=280 ,DepartmentId=2},
                    new Food{ Id = 4,Name="full fat yogurt",Image="full fat yogurt.jpeg",Calory=70 ,DepartmentId=3},
                    new Food{ Id = 5,Name="banana",Image="banana.jpeg",Calory=65 ,DepartmentId=4},
                });
            modelBuilder.Entity<Department>()
                .HasData(new Department[]
                {
                    new Department{ Id = 1,Name="Carbohydrates",Image="carbohydrates.jpeg"},
                    new Department{ Id = 2,Name="Protein",Image="protein.jpeg"},
                    new Department{ Id = 3,Name="Dairy products",Image="dairy products.jpeg"},
                    new Department{ Id = 4,Name="Fruit and vegetables",Image="fruit and vegetables.jpeg"},
                    new Department{ Id = 5,Name="Fats and sugars",Image="fats and sugars.jpeg"},

                });



        }
    }
}
