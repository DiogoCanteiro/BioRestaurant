using Microsoft.EntityFrameworkCore.Migrations;

namespace Bio.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Fruit", "A mango is an edible stone fruit produced by the tropical tree Mangifera indica.", "", "Mango", 0.79000000000000004 },
                    { 2, "Appetizer", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante", "", "Cheese Ball", 2.5899999999999999 },
                    { 3, "Dessert", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante", "", "Cupcake", 5.0 },
                    { 4, "Entree", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante", "", "Hibachi Chicken", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
