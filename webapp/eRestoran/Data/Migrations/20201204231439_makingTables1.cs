using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class makingTables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NarudzbaStavka",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PonudaStavka",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PonudaStavka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StavkaUlaza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaUlaza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnlineNarudzba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    NarudzbaStavkaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineNarudzba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineNarudzba_NarudzbaStavka_NarudzbaStavkaID",
                        column: x => x.NarudzbaStavkaID,
                        principalTable: "NarudzbaStavka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DnevnaPonuda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<string>(nullable: true),
                    PonudaStavkaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DnevnaPonuda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DnevnaPonuda_PonudaStavka_PonudaStavkaId",
                        column: x => x.PonudaStavkaId,
                        principalTable: "PonudaStavka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meni",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<string>(nullable: true),
                    StanjeNaSkladistu = table.Column<float>(nullable: false),
                    ZaDostavu = table.Column<string>(nullable: true),
                    NarudzbaStavkaID = table.Column<int>(nullable: false),
                    PonudaStavkaID = table.Column<int>(nullable: false),
                    StavkaUlazaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meni_NarudzbaStavka_NarudzbaStavkaID",
                        column: x => x.NarudzbaStavkaID,
                        principalTable: "NarudzbaStavka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meni_PonudaStavka_PonudaStavkaID",
                        column: x => x.PonudaStavkaID,
                        principalTable: "PonudaStavka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meni_StavkaUlaza_StavkaUlazaID",
                        column: x => x.StavkaUlazaID,
                        principalTable: "StavkaUlaza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DostavaNalog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    OnlineNarudzbaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DostavaNalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DostavaNalog_OnlineNarudzba_OnlineNarudzbaID",
                        column: x => x.OnlineNarudzbaID,
                        principalTable: "OnlineNarudzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKategorije = table.Column<string>(nullable: true),
                    MeniID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kategorija_Meni_MeniID",
                        column: x => x.MeniID,
                        principalTable: "Meni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DnevnaPonuda_PonudaStavkaId",
                table: "DnevnaPonuda",
                column: "PonudaStavkaId");

            migrationBuilder.CreateIndex(
                name: "IX_DostavaNalog_OnlineNarudzbaID",
                table: "DostavaNalog",
                column: "OnlineNarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_Kategorija_MeniID",
                table: "Kategorija",
                column: "MeniID");

            migrationBuilder.CreateIndex(
                name: "IX_Meni_NarudzbaStavkaID",
                table: "Meni",
                column: "NarudzbaStavkaID");

            migrationBuilder.CreateIndex(
                name: "IX_Meni_PonudaStavkaID",
                table: "Meni",
                column: "PonudaStavkaID");

            migrationBuilder.CreateIndex(
                name: "IX_Meni_StavkaUlazaID",
                table: "Meni",
                column: "StavkaUlazaID");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineNarudzba_NarudzbaStavkaID",
                table: "OnlineNarudzba",
                column: "NarudzbaStavkaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DnevnaPonuda");

            migrationBuilder.DropTable(
                name: "DostavaNalog");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "OnlineNarudzba");

            migrationBuilder.DropTable(
                name: "Meni");

            migrationBuilder.DropTable(
                name: "NarudzbaStavka");

            migrationBuilder.DropTable(
                name: "PonudaStavka");

            migrationBuilder.DropTable(
                name: "StavkaUlaza");
        }
    }
}
