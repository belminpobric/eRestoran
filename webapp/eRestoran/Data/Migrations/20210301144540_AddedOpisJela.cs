using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class AddedOpisJela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Opis",
                table: "Meni",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Meni");
        }
    }
}
