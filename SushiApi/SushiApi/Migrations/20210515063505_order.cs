using Microsoft.EntityFrameworkCore.Migrations;

namespace SushiApi.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SushiInSets_Orders_OrderID",
                table: "SushiInSets");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "SushiInSets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SushiInSets_Orders_OrderID",
                table: "SushiInSets",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SushiInSets_Orders_OrderID",
                table: "SushiInSets");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "SushiInSets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SushiInSets_Orders_OrderID",
                table: "SushiInSets",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
