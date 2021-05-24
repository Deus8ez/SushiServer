using Microsoft.EntityFrameworkCore.Migrations;

namespace SushiApi.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "ID", "Amount", "CostPerPiece", "Name" },
                values: new object[] { 2, 1, 3m, "California" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
