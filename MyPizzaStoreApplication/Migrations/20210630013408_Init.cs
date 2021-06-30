using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPizzaStoreApplication.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVeg = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Crust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Crust", "IsVeg", "Name", "Pic", "Price" },
                values: new object[] { 101, "Wheat Thin", true, "Margherita", "/images/Pic1.jpg", 12f });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Crust", "IsVeg", "Name", "Pic", "Price" },
                values: new object[] { 102, "Cheezee", true, "Mexican Green Wave", "/images/Pic2.jpg", 24f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
