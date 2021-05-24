using Microsoft.EntityFrameworkCore.Migrations;

namespace SushiApi.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "ID", "Cost", "Custom", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, 20m, false, "Hot shot", 3 },
                    { 2, 15m, false, "Magura", 4 },
                    { 3, 30m, false, "Pikachu", 5 },
                    { 4, 10m, false, "Sakura", 4 },
                    { 5, 25m, false, "Tokio", 2 }
                });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "ID", "Amount", "CostPerPiece", "Name" },
                values: new object[,]
                {
                    { 13, 1, 3m, "Sushi todi" },
                    { 12, 1, 5m, "Spicy tuna" },
                    { 11, 1, 7m, "Special salmon" },
                    { 10, 1, 5m, "Smoked salmon" },
                    { 9, 1, 2m, "Salmon cheese" },
                    { 6, 1, 7m, "Mais" },
                    { 7, 1, 5m, "Sake maki" },
                    { 14, 1, 5m, "Torico" },
                    { 5, 1, 5m, "Karu maki" },
                    { 4, 1, 4m, "Kappa maki" },
                    { 3, 1, 3m, "Dragon" },
                    { 8, 1, 8m, "Sake" },
                    { 15, 1, 10m, "Unagi" }
                });

            migrationBuilder.InsertData(
                table: "SushiInSets",
                columns: new[] { "SushiInSetsID", "SetID", "SushiAmount", "SushiID" },
                values: new object[,]
                {
                    { 6, 4, 2, 7 },
                    { 3, 3, 5, 9 },
                    { 1, 1, 4, 10 },
                    { 5, 5, 5, 10 },
                    { 2, 2, 3, 12 },
                    { 4, 3, 4, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SushiInSets",
                keyColumn: "SushiInSetsID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SushiInSets",
                keyColumn: "SushiInSetsID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SushiInSets",
                keyColumn: "SushiInSetsID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SushiInSets",
                keyColumn: "SushiInSetsID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SushiInSets",
                keyColumn: "SushiInSetsID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SushiInSets",
                keyColumn: "SushiInSetsID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "ID",
                keyValue: 14);
        }
    }
}
