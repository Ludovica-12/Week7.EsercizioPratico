using Microsoft.EntityFrameworkCore.Migrations;

namespace Week7.EsercizioPratico.RepositoryEF.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatti",
                columns: table => new
                {
                    ContattoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatti", x => x.ContattoID);
                });

            migrationBuilder.CreateTable(
                name: "Indirizzi",
                columns: table => new
                {
                    IndirizzoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipologia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Via = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Citta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAP = table.Column<int>(type: "int", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContattoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indirizzi", x => x.IndirizzoID);
                    table.ForeignKey(
                        name: "FK_Indirizzi_Contatti_ContattoID",
                        column: x => x.ContattoID,
                        principalTable: "Contatti",
                        principalColumn: "ContattoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Indirizzi_ContattoID",
                table: "Indirizzi",
                column: "ContattoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indirizzi");

            migrationBuilder.DropTable(
                name: "Contatti");
        }
    }
}
