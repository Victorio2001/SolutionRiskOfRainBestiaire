using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiskOfRain.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attaques",
                columns: table => new
                {
                    IdAttaque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomAttaque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Physique = table.Column<int>(type: "int", nullable: false),
                    Magie = table.Column<int>(type: "int", nullable: false),
                    CoutPointCombat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attaques", x => x.IdAttaque);
                });

            migrationBuilder.CreateTable(
                name: "Monstres",
                columns: table => new
                {
                    IdMonstre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomMonstre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PointCombatMonstre = table.Column<int>(type: "int", nullable: false),
                    CouleurMonstre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PvMonstre = table.Column<int>(type: "int", nullable: false),
                    PvMaxMonstre = table.Column<int>(type: "int", nullable: false),
                    TypeMonstre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monstres", x => x.IdMonstre);
                });

            migrationBuilder.CreateTable(
                name: "AttaqueMonstre",
                columns: table => new
                {
                    IdAttaqueMonstre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMonstre = table.Column<int>(type: "int", nullable: false),
                    IdAttaque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttaqueMonstre", x => x.IdAttaqueMonstre);
                    table.ForeignKey(
                        name: "FK_AttaqueMonstre_Attaques_IdAttaque",
                        column: x => x.IdAttaque,
                        principalTable: "Attaques",
                        principalColumn: "IdAttaque",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttaqueMonstre_Monstres_IdMonstre",
                        column: x => x.IdMonstre,
                        principalTable: "Monstres",
                        principalColumn: "IdMonstre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttaqueMonstre_IdAttaque",
                table: "AttaqueMonstre",
                column: "IdAttaque");

            migrationBuilder.CreateIndex(
                name: "IX_AttaqueMonstre_IdMonstre",
                table: "AttaqueMonstre",
                column: "IdMonstre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttaqueMonstre");

            migrationBuilder.DropTable(
                name: "Attaques");

            migrationBuilder.DropTable(
                name: "Monstres");
        }
    }
}
