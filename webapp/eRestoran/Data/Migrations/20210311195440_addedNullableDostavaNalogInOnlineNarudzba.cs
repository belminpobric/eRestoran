using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class addedNullableDostavaNalogInOnlineNarudzba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineNarudzba_DostavaNalog_DostavaNalogID",
                table: "OnlineNarudzba");

            migrationBuilder.AlterColumn<int>(
                name: "DostavaNalogID",
                table: "OnlineNarudzba",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineNarudzba_DostavaNalog_DostavaNalogID",
                table: "OnlineNarudzba",
                column: "DostavaNalogID",
                principalTable: "DostavaNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineNarudzba_DostavaNalog_DostavaNalogID",
                table: "OnlineNarudzba");

            migrationBuilder.AlterColumn<int>(
                name: "DostavaNalogID",
                table: "OnlineNarudzba",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineNarudzba_DostavaNalog_DostavaNalogID",
                table: "OnlineNarudzba",
                column: "DostavaNalogID",
                principalTable: "DostavaNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
