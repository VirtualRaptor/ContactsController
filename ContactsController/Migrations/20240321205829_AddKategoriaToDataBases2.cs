using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsController.Migrations
{
    public partial class AddKategoriaToDataBases2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kategoria",
                table: "Kategorie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kategoria",
                table: "Kategorie");
        }
    }
}
