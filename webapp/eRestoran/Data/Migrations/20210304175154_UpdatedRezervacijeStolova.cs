using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class UpdatedRezervacijeStolova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_AspNetUsers_OnlineGostId",
                table: "RezervacijaStolova");

            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_Stol_StolID",
                table: "RezervacijaStolova");

            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_Uposleniks_UposlenikID",
                table: "RezervacijaStolova");

            migrationBuilder.DropTable(
                name: "Stol");

            migrationBuilder.DropIndex(
                name: "IX_RezervacijaStolova_OnlineGostId",
                table: "RezervacijaStolova");

            migrationBuilder.DropIndex(
                name: "IX_RezervacijaStolova_StolID",
                table: "RezervacijaStolova");

            migrationBuilder.DropIndex(
                name: "IX_RezervacijaStolova_UposlenikID",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "Odobreno",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "OnlineGostID",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "OnlineGostId",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "StolID",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "UposlenikID",
                table: "RezervacijaStolova");

            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "RezervacijaStolova",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "RezervacijaStolova");

            migrationBuilder.AddColumn<bool>(
                name: "Odobreno",
                table: "RezervacijaStolova",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OnlineGostID",
                table: "RezervacijaStolova",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OnlineGostId",
                table: "RezervacijaStolova",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StolID",
                table: "RezervacijaStolova",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UposlenikID",
                table: "RezervacijaStolova",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrMjesta = table.Column<int>(type: "int", nullable: false),
                    BrStola = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stol", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStolova_OnlineGostId",
                table: "RezervacijaStolova",
                column: "OnlineGostId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStolova_StolID",
                table: "RezervacijaStolova",
                column: "StolID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStolova_UposlenikID",
                table: "RezervacijaStolova",
                column: "UposlenikID");

            migrationBuilder.AddForeignKey(
                name: "FK_RezervacijaStolova_AspNetUsers_OnlineGostId",
                table: "RezervacijaStolova",
                column: "OnlineGostId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RezervacijaStolova_Stol_StolID",
                table: "RezervacijaStolova",
                column: "StolID",
                principalTable: "Stol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RezervacijaStolova_Uposleniks_UposlenikID",
                table: "RezervacijaStolova",
                column: "UposlenikID",
                principalTable: "Uposleniks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
