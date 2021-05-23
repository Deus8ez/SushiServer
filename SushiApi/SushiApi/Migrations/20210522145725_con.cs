using Microsoft.EntityFrameworkCore.Migrations;

namespace SushiApi.Migrations
{
    public partial class con : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetsInOrders_SushiInSets_SushiInSetsID",
                table: "SetsInOrders");

            migrationBuilder.RenameColumn(
                name: "SushiInSetsID",
                table: "SetsInOrders",
                newName: "SetID");

            migrationBuilder.RenameIndex(
                name: "IX_SetsInOrders_SushiInSetsID",
                table: "SetsInOrders",
                newName: "IX_SetsInOrders_SetID");

            migrationBuilder.AddForeignKey(
                name: "FK_SetsInOrders_Sets_SetID",
                table: "SetsInOrders",
                column: "SetID",
                principalTable: "Sets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetsInOrders_Sets_SetID",
                table: "SetsInOrders");

            migrationBuilder.RenameColumn(
                name: "SetID",
                table: "SetsInOrders",
                newName: "SushiInSetsID");

            migrationBuilder.RenameIndex(
                name: "IX_SetsInOrders_SetID",
                table: "SetsInOrders",
                newName: "IX_SetsInOrders_SushiInSetsID");

            migrationBuilder.AddForeignKey(
                name: "FK_SetsInOrders_SushiInSets_SushiInSetsID",
                table: "SetsInOrders",
                column: "SushiInSetsID",
                principalTable: "SushiInSets",
                principalColumn: "SushiInSetsID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
