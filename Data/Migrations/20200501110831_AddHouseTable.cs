using Microsoft.EntityFrameworkCore.Migrations;

namespace Immobilien.Data.Migrations
{
    public partial class AddHouseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Ort = table.Column<string>(nullable: false),
                    Kauf = table.Column<bool>(nullable: false),
                    Beschreibung = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    Grund = table.Column<double>(nullable: false),
                    Keller = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    Wohnflaeche = table.Column<double>(nullable: false),
                    Geschossbeschreibung = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    Heizung = table.Column<string>(nullable: true),
                    Hwb = table.Column<double>(nullable: false),
                    Preis = table.Column<double>(nullable: false),
                    Miete = table.Column<double>(nullable: false),
                    Kaution = table.Column<double>(nullable: false),
                    Abloese = table.Column<double>(nullable: false),
                    Schlusstext = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
