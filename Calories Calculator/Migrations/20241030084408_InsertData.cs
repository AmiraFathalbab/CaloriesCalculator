using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Calories_Calculator.Migrations
{
    /// <inheritdoc />
    public partial class InsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "carbohydrates.jpeg", "Carbohydrates" },
                    { 2, "protein.jpeg", "Protein" },
                    { 3, "dairy products.jpeg", "Dairy products" },
                    { 4, "fruit and vegetables.jpeg", "Fruit and vegetables" },
                    { 5, "fats and sugars.jpeg", "Fats and sugars" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calory", "DepartmentId", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 140, 1, "white rice.jpeg", "white rice" },
                    { 2, 135, 1, "brown rice.jpg", "brown rice" },
                    { 3, 280, 2, "beef.jpeg", "beef" },
                    { 4, 70, 3, "full fat yogurt.jpeg", "full fat yogurt" },
                    { 5, 65, 4, "banana.jpeg", "banana" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
