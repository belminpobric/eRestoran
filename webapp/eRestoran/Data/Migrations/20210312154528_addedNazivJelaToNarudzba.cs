using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class addedNazivJelaToNarudzba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NazivJela",
                table: "OnlineNarudzba",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NazivJela",
                table: "OnlineNarudzba");
        }
    }
}
