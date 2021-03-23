using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "PonudaStavka");

            migrationBuilder.DropColumn(
                name: "Datum",
                table: "OnlineNarudzba");

            migrationBuilder.DropColumn(
                name: "Datum",
                table: "DostavaNalog");

            migrationBuilder.AddColumn<string>(
                name: "DostupnaKolicina",
                table: "PonudaStavka",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Cijena",
                table: "OnlineNarudzba",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumNarudzbe",
                table: "OnlineNarudzba",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "OnlineNarudzba",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "OnlineNarudzba",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Meni",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumIsporuke",
                table: "DostavaNalog",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Notifikacije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poruka = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Obavijestis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poruka = table.Column<string>(nullable: true),
                    DatumVrijeme = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijestis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaStolova",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Odobreno = table.Column<bool>(nullable: false),
                    BrojOsoba = table.Column<int>(nullable: false),
                    VrijemeRezervacije = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijaStolova", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UlazUSkladiste",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<float>(nullable: false),
                    KolicinaUlaza = table.Column<float>(nullable: false),
                    ImeDobavljaca = table.Column<string>(nullable: true),
                    DatumPrijema = table.Column<DateTime>(nullable: false),
                    StavkaUlazaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UlazUSkladiste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UlazUSkladiste_StavkaUlaza_StavkaUlazaId",
                        column: x => x.StavkaUlazaId,
                        principalTable: "StavkaUlaza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoziloZaDostavu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Tip = table.Column<string>(nullable: true),
                    DostavaNalogID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoziloZaDostavu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoziloZaDostavu_DostavaNalog_DostavaNalogID",
                        column: x => x.DostavaNalogID,
                        principalTable: "DostavaNalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlineGost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NotifikacijeId = table.Column<int>(nullable: false),
                    RezervacijaStolovaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineGost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineGost_Notifikacije_NotifikacijeId",
                        column: x => x.NotifikacijeId,
                        principalTable: "Notifikacije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineGost_RezervacijaStolova_RezervacijaStolovaId",
                        column: x => x.RezervacijaStolovaId,
                        principalTable: "RezervacijaStolova",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrStola = table.Column<int>(nullable: false),
                    BrMjesta = table.Column<int>(nullable: false),
                    RezervacijaStolovaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stol_RezervacijaStolova_RezervacijaStolovaID",
                        column: x => x.RezervacijaStolovaID,
                        principalTable: "RezervacijaStolova",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uposleniks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Titula = table.Column<string>(nullable: true),
                    RezervacijaStolovaId = table.Column<int>(nullable: false),
                    DostavaNalogId = table.Column<int>(nullable: false),
                    UlazUSkladisteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposleniks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uposleniks_DostavaNalog_DostavaNalogId",
                        column: x => x.DostavaNalogId,
                        principalTable: "DostavaNalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uposleniks_RezervacijaStolova_RezervacijaStolovaId",
                        column: x => x.RezervacijaStolovaId,
                        principalTable: "RezervacijaStolova",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uposleniks_UlazUSkladiste_UlazUSkladisteID",
                        column: x => x.UlazUSkladisteID,
                        principalTable: "UlazUSkladiste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restoran",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Vlasnik = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    UposlenikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restoran", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restoran_Uposleniks_UposlenikID",
                        column: x => x.UposlenikID,
                        principalTable: "Uposleniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UposlenikObavijesti",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(nullable: false),
                    ObavijestiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UposlenikObavijesti", x => new { x.UposlenikId, x.ObavijestiId });
                    table.ForeignKey(
                        name: "FK_UposlenikObavijesti_Obavijestis_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Obavijestis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UposlenikObavijesti_Uposleniks_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposleniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineGost_NotifikacijeId",
                table: "OnlineGost",
                column: "NotifikacijeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineGost_RezervacijaStolovaId",
                table: "OnlineGost",
                column: "RezervacijaStolovaId");

            migrationBuilder.CreateIndex(
                name: "IX_Restoran_UposlenikID",
                table: "Restoran",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_Stol_RezervacijaStolovaID",
                table: "Stol",
                column: "RezervacijaStolovaID");

            migrationBuilder.CreateIndex(
                name: "IX_UlazUSkladiste_StavkaUlazaId",
                table: "UlazUSkladiste",
                column: "StavkaUlazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposleniks_DostavaNalogId",
                table: "Uposleniks",
                column: "DostavaNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposleniks_RezervacijaStolovaId",
                table: "Uposleniks",
                column: "RezervacijaStolovaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposleniks_UlazUSkladisteID",
                table: "Uposleniks",
                column: "UlazUSkladisteID");

            migrationBuilder.CreateIndex(
                name: "IX_VoziloZaDostavu_DostavaNalogID",
                table: "VoziloZaDostavu",
                column: "DostavaNalogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnlineGost");

            migrationBuilder.DropTable(
                name: "Restoran");

            migrationBuilder.DropTable(
                name: "Stol");

            migrationBuilder.DropTable(
                name: "UposlenikObavijesti");

            migrationBuilder.DropTable(
                name: "VoziloZaDostavu");

            migrationBuilder.DropTable(
                name: "Notifikacije");

            migrationBuilder.DropTable(
                name: "Obavijestis");

            migrationBuilder.DropTable(
                name: "Uposleniks");

            migrationBuilder.DropTable(
                name: "RezervacijaStolova");

            migrationBuilder.DropTable(
                name: "UlazUSkladiste");

            migrationBuilder.DropColumn(
                name: "DostupnaKolicina",
                table: "PonudaStavka");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "OnlineNarudzba");

            migrationBuilder.DropColumn(
                name: "DatumNarudzbe",
                table: "OnlineNarudzba");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "OnlineNarudzba");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "OnlineNarudzba");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "DatumIsporuke",
                table: "DostavaNalog");

            migrationBuilder.AddColumn<string>(
                name: "Kolicina",
                table: "PonudaStavka",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Datum",
                table: "OnlineNarudzba",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datum",
                table: "DostavaNalog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
