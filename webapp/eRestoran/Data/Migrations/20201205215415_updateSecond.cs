using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class updateSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UposlenikObavijesti_Uposleniks_UposlenikId",
                table: "UposlenikObavijesti");

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikObavijesti_ObavijestiId",
                table: "UposlenikObavijesti",
                column: "ObavijestiId");

            migrationBuilder.AddForeignKey(
                name: "FK_UposlenikObavijesti_Uposleniks_ObavijestiId",
                table: "UposlenikObavijesti",
                column: "ObavijestiId",
                principalTable: "Uposleniks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UposlenikObavijesti_Uposleniks_ObavijestiId",
                table: "UposlenikObavijesti");

            migrationBuilder.DropIndex(
                name: "IX_UposlenikObavijesti_ObavijestiId",
                table: "UposlenikObavijesti");

            migrationBuilder.AddForeignKey(
                name: "FK_UposlenikObavijesti_Uposleniks_UposlenikId",
                table: "UposlenikObavijesti",
                column: "UposlenikId",
                principalTable: "Uposleniks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
