using Microsoft.EntityFrameworkCore.Migrations;

namespace SushiApi.Migrations
{
    public partial class so : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SetsInOrders",
                columns: table => new
                {
                    SetsInOrdersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SushiInSetsID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetsInOrders", x => x.SetsInOrdersID);
                    table.ForeignKey(
                        name: "FK_SetsInOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetsInOrders_SushiInSets_SushiInSetsID",
                        column: x => x.SushiInSetsID,
                        principalTable: "SushiInSets",
                        principalColumn: "SushiInSetsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SetsInOrders_OrderID",
                table: "SetsInOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_SetsInOrders_SushiInSetsID",
                table: "SetsInOrders",
                column: "SushiInSetsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetsInOrders");
        }
    }
}
