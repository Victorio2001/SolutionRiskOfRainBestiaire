using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RiskOfRain.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attaques",
                columns: new[] { "IdAttaque", "CoutPointCombat", "Magie", "NomAttaque", "Physique" },
                values: new object[,]
                {
                    { 1, 5, 0, "Charge", 40 },
                    { 2, 15, 65, "FireBall", 0 },
                    { 3, 10, 0, "FirePunch", 60 }
                });

            migrationBuilder.InsertData(
                table: "Monstres",
                columns: new[] { "IdMonstre", "CouleurMonstre", "NomMonstre", "PointCombatMonstre", "PvMaxMonstre", "PvMonstre", "TypeMonstre" },
                values: new object[,]
                {
                    { 1, "Rouge", "Alpha Construct", 55, 0, 125, "Mutant" },
                    { 2, "Bleu", "Alloy Vulture", 120, 0, 180, "Mage" }
                });

            migrationBuilder.InsertData(
                table: "AttaqueMonstre",
                columns: new[] { "IdAttaqueMonstre", "IdAttaque", "IdMonstre" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AttaqueMonstre",
                keyColumn: "IdAttaqueMonstre",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AttaqueMonstre",
                keyColumn: "IdAttaqueMonstre",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "IdAttaque",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "IdMonstre",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "IdAttaque",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "IdAttaque",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "IdMonstre",
                keyValue: 1);
        }
    }
}
