using Microsoft.EntityFrameworkCore.Migrations;

namespace MoreOnEFProject.Migrations
{
    public partial class CompositeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    BillNumber = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => new { x.BillNumber, x.ItemId });
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_BillNumber",
                        column: x => x.BillNumber,
                        principalTable: "Bills",
                        principalColumn: "BillNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ItemId",
                table: "BillDetails",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetails");
        }
    }
}
