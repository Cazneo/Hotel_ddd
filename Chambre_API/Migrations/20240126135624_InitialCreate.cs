using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChambreAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeChambreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixParNuit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeChambreID);
                });

            migrationBuilder.CreateTable(
                name: "Chambres",
                columns: table => new
                {
                    ChambreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeChambreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambres", x => x.ChambreID);
                    table.ForeignKey(
                        name: "FK_Chambres_Types_TypeChambreID",
                        column: x => x.TypeChambreID,
                        principalTable: "Types",
                        principalColumn: "TypeChambreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipements",
                columns: table => new
                {
                    EquipementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeChambreID = table.Column<int>(type: "int", nullable: false),
                    NomEquipement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipements", x => x.EquipementID);
                    table.ForeignKey(
                        name: "FK_Equipements_Types_TypeChambreID",
                        column: x => x.TypeChambreID,
                        principalTable: "Types",
                        principalColumn: "TypeChambreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chambres_TypeChambreID",
                table: "Chambres",
                column: "TypeChambreID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipements_TypeChambreID",
                table: "Equipements",
                column: "TypeChambreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chambres");

            migrationBuilder.DropTable(
                name: "Equipements");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
