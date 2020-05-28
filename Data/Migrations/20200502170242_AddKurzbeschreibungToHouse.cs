using Microsoft.EntityFrameworkCore.Migrations;

namespace Immobilien.Data.Migrations
{
    public partial class AddKurzbeschreibungToHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kurzbeschreibung",
                table: "Houses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kurzbeschreibung",
                table: "Houses");
        }
    }
}
