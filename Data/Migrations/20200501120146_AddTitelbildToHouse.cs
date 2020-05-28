using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Immobilien.Data.Migrations
{
    public partial class AddTitelbildToHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Titelbild",
                table: "Houses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titelbild",
                table: "Houses");
        }
    }
}
