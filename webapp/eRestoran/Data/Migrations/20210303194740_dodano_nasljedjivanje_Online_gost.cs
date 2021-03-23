using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class dodano_nasljedjivanje_Online_gost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacije_OnlineGost_OnlineGostID",
                table: "Notifikacije");

            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_OnlineGost_OnlineGostID",
                table: "RezervacijaStolova");

            migrationBuilder.DropTable(
                name: "OnlineGost");

            migrationBuilder.RenameColumn(
                name: "OnlineGostID",
                table: "RezervacijaStolova",
                newName: "OnlineGostId");

            migrationBuilder.RenameIndex(
                name: "IX_RezervacijaStolova_OnlineGostID",
                table: "RezervacijaStolova",
                newName: "IX_RezervacijaStolova_OnlineGostId");

            migrationBuilder.RenameColumn(
                name: "OnlineGostID",
                table: "Notifikacije",
                newName: "OnlineGostId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifikacije_OnlineGostID",
                table: "Notifikacije",
                newName: "IX_Notifikacije_OnlineGostId");

            migrationBuilder.AlterColumn<string>(
                name: "OnlineGostId",
                table: "RezervacijaStolova",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OnlineGostID",
                table: "RezervacijaStolova",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "OnlineGostId",
                table: "Notifikacije",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OnlineGostID",
                table: "Notifikacije",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacije_AspNetUsers_OnlineGostId",
                table: "Notifikacije",
                column: "OnlineGostId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RezervacijaStolova_AspNetUsers_OnlineGostId",
                table: "RezervacijaStolova",
                column: "OnlineGostId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacije_AspNetUsers_OnlineGostId",
                table: "Notifikacije");

            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_AspNetUsers_OnlineGostId",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "OnlineGostID",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "OnlineGostID",
                table: "Notifikacije");

            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "OnlineGostId",
                table: "RezervacijaStolova",
                newName: "OnlineGostID");

            migrationBuilder.RenameIndex(
                name: "IX_RezervacijaStolova_OnlineGostId",
                table: "RezervacijaStolova",
                newName: "IX_RezervacijaStolova_OnlineGostID");

            migrationBuilder.RenameColumn(
                name: "OnlineGostId",
                table: "Notifikacije",
                newName: "OnlineGostID");

            migrationBuilder.RenameIndex(
                name: "IX_Notifikacije_OnlineGostId",
                table: "Notifikacije",
                newName: "IX_Notifikacije_OnlineGostID");

            migrationBuilder.AlterColumn<int>(
                name: "OnlineGostID",
                table: "RezervacijaStolova",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OnlineGostID",
                table: "Notifikacije",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "OnlineGost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineGost", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacije_OnlineGost_OnlineGostID",
                table: "Notifikacije",
                column: "OnlineGostID",
                principalTable: "OnlineGost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RezervacijaStolova_OnlineGost_OnlineGostID",
                table: "RezervacijaStolova",
                column: "OnlineGostID",
                principalTable: "OnlineGost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
