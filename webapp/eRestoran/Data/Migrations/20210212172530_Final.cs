using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.Data.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DnevnaPonuda_PonudaStavka_PonudaStavkaId",
                table: "DnevnaPonuda");

            migrationBuilder.DropForeignKey(
                name: "FK_DostavaNalog_OnlineNarudzba_OnlineNarudzbaID",
                table: "DostavaNalog");

            migrationBuilder.DropForeignKey(
                name: "FK_Kategorija_Meni_MeniID",
                table: "Kategorija");

            migrationBuilder.DropForeignKey(
                name: "FK_Meni_NarudzbaStavka_NarudzbaStavkaID",
                table: "Meni");

            migrationBuilder.DropForeignKey(
                name: "FK_Meni_PonudaStavka_PonudaStavkaID",
                table: "Meni");

            migrationBuilder.DropForeignKey(
                name: "FK_Meni_StavkaUlaza_StavkaUlazaID",
                table: "Meni");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineGost_Notifikacije_NotifikacijeId",
                table: "OnlineGost");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineGost_RezervacijaStolova_RezervacijaStolovaId",
                table: "OnlineGost");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineNarudzba_NarudzbaStavka_NarudzbaStavkaID",
                table: "OnlineNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Restoran_Uposleniks_UposlenikID",
                table: "Restoran");

            migrationBuilder.DropForeignKey(
                name: "FK_Stol_RezervacijaStolova_RezervacijaStolovaID",
                table: "Stol");

            migrationBuilder.DropForeignKey(
                name: "FK_UlazUSkladiste_StavkaUlaza_StavkaUlazaId",
                table: "UlazUSkladiste");

            migrationBuilder.DropForeignKey(
                name: "FK_Uposleniks_DostavaNalog_DostavaNalogId",
                table: "Uposleniks");

            migrationBuilder.DropForeignKey(
                name: "FK_Uposleniks_RezervacijaStolova_RezervacijaStolovaId",
                table: "Uposleniks");

            migrationBuilder.DropForeignKey(
                name: "FK_Uposleniks_UlazUSkladiste_UlazUSkladisteID",
                table: "Uposleniks");

            migrationBuilder.DropForeignKey(
                name: "FK_VoziloZaDostavu_DostavaNalog_DostavaNalogID",
                table: "VoziloZaDostavu");

            migrationBuilder.DropIndex(
                name: "IX_VoziloZaDostavu_DostavaNalogID",
                table: "VoziloZaDostavu");

            migrationBuilder.DropIndex(
                name: "IX_Uposleniks_DostavaNalogId",
                table: "Uposleniks");

            migrationBuilder.DropIndex(
                name: "IX_Uposleniks_RezervacijaStolovaId",
                table: "Uposleniks");

            migrationBuilder.DropIndex(
                name: "IX_Uposleniks_UlazUSkladisteID",
                table: "Uposleniks");

            migrationBuilder.DropIndex(
                name: "IX_UlazUSkladiste_StavkaUlazaId",
                table: "UlazUSkladiste");

            migrationBuilder.DropIndex(
                name: "IX_Stol_RezervacijaStolovaID",
                table: "Stol");

            migrationBuilder.DropIndex(
                name: "IX_Restoran_UposlenikID",
                table: "Restoran");

            migrationBuilder.DropIndex(
                name: "IX_OnlineNarudzba_NarudzbaStavkaID",
                table: "OnlineNarudzba");

            migrationBuilder.DropIndex(
                name: "IX_OnlineGost_NotifikacijeId",
                table: "OnlineGost");

            migrationBuilder.DropIndex(
                name: "IX_OnlineGost_RezervacijaStolovaId",
                table: "OnlineGost");

            migrationBuilder.DropIndex(
                name: "IX_Meni_NarudzbaStavkaID",
                table: "Meni");

            migrationBuilder.DropIndex(
                name: "IX_Meni_PonudaStavkaID",
                table: "Meni");

            migrationBuilder.DropIndex(
                name: "IX_Meni_StavkaUlazaID",
                table: "Meni");

            migrationBuilder.DropIndex(
                name: "IX_Kategorija_MeniID",
                table: "Kategorija");

            migrationBuilder.DropIndex(
                name: "IX_DostavaNalog_OnlineNarudzbaID",
                table: "DostavaNalog");

            migrationBuilder.DropIndex(
                name: "IX_DnevnaPonuda_PonudaStavkaId",
                table: "DnevnaPonuda");

            migrationBuilder.DropColumn(
                name: "DostavaNalogID",
                table: "VoziloZaDostavu");

            migrationBuilder.DropColumn(
                name: "DostavaNalogId",
                table: "Uposleniks");

            migrationBuilder.DropColumn(
                name: "RezervacijaStolovaId",
                table: "Uposleniks");

            migrationBuilder.DropColumn(
                name: "UlazUSkladisteID",
                table: "Uposleniks");

            migrationBuilder.DropColumn(
                name: "StavkaUlazaId",
                table: "UlazUSkladiste");

            migrationBuilder.DropColumn(
                name: "RezervacijaStolovaID",
                table: "Stol");

            migrationBuilder.DropColumn(
                name: "UposlenikID",
                table: "Restoran");

            migrationBuilder.DropColumn(
                name: "NarudzbaStavkaID",
                table: "OnlineNarudzba");

            migrationBuilder.DropColumn(
                name: "NotifikacijeId",
                table: "OnlineGost");

            migrationBuilder.DropColumn(
                name: "RezervacijaStolovaId",
                table: "OnlineGost");

            migrationBuilder.DropColumn(
                name: "NarudzbaStavkaID",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "PonudaStavkaID",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "StavkaUlazaID",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "MeniID",
                table: "Kategorija");

            migrationBuilder.DropColumn(
                name: "OnlineNarudzbaID",
                table: "DostavaNalog");

            migrationBuilder.DropColumn(
                name: "PonudaStavkaId",
                table: "DnevnaPonuda");

            migrationBuilder.AddColumn<int>(
                name: "RestoranID",
                table: "Uposleniks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UposlenikID",
                table: "UlazUSkladiste",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeniID",
                table: "StavkaUlaza",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UlazUSkladisteID",
                table: "StavkaUlaza",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnlineGostID",
                table: "RezervacijaStolova",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StolID",
                table: "RezervacijaStolova",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UposlenikID",
                table: "RezervacijaStolova",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DnevnaPonudaID",
                table: "PonudaStavka",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeniID",
                table: "PonudaStavka",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DostavaNalogID",
                table: "OnlineNarudzba",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnlineGostID",
                table: "Notifikacije",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DnevnaPonudaID",
                table: "NarudzbaStavka",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeniID",
                table: "NarudzbaStavka",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnlineNarudzbaID",
                table: "NarudzbaStavka",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategorijaID",
                table: "Meni",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UposlenikID",
                table: "DostavaNalog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoziloZaDostavuID",
                table: "DostavaNalog",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uposleniks_RestoranID",
                table: "Uposleniks",
                column: "RestoranID");

            migrationBuilder.CreateIndex(
                name: "IX_UlazUSkladiste_UposlenikID",
                table: "UlazUSkladiste",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaUlaza_MeniID",
                table: "StavkaUlaza",
                column: "MeniID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaUlaza_UlazUSkladisteID",
                table: "StavkaUlaza",
                column: "UlazUSkladisteID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStolova_OnlineGostID",
                table: "RezervacijaStolova",
                column: "OnlineGostID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStolova_StolID",
                table: "RezervacijaStolova",
                column: "StolID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStolova_UposlenikID",
                table: "RezervacijaStolova",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_PonudaStavka_DnevnaPonudaID",
                table: "PonudaStavka",
                column: "DnevnaPonudaID");

            migrationBuilder.CreateIndex(
                name: "IX_PonudaStavka_MeniID",
                table: "PonudaStavka",
                column: "MeniID");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineNarudzba_DostavaNalogID",
                table: "OnlineNarudzba",
                column: "DostavaNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_OnlineGostID",
                table: "Notifikacije",
                column: "OnlineGostID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavka_DnevnaPonudaID",
                table: "NarudzbaStavka",
                column: "DnevnaPonudaID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavka_MeniID",
                table: "NarudzbaStavka",
                column: "MeniID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavka_OnlineNarudzbaID",
                table: "NarudzbaStavka",
                column: "OnlineNarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_Meni_KategorijaID",
                table: "Meni",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_DostavaNalog_UposlenikID",
                table: "DostavaNalog",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_DostavaNalog_VoziloZaDostavuID",
                table: "DostavaNalog",
                column: "VoziloZaDostavuID");

            migrationBuilder.AddForeignKey(
                name: "FK_DostavaNalog_Uposleniks_UposlenikID",
                table: "DostavaNalog",
                column: "UposlenikID",
                principalTable: "Uposleniks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DostavaNalog_VoziloZaDostavu_VoziloZaDostavuID",
                table: "DostavaNalog",
                column: "VoziloZaDostavuID",
                principalTable: "VoziloZaDostavu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meni_Kategorija_KategorijaID",
                table: "Meni",
                column: "KategorijaID",
                principalTable: "Kategorija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarudzbaStavka_DnevnaPonuda_DnevnaPonudaID",
                table: "NarudzbaStavka",
                column: "DnevnaPonudaID",
                principalTable: "DnevnaPonuda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarudzbaStavka_Meni_MeniID",
                table: "NarudzbaStavka",
                column: "MeniID",
                principalTable: "Meni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarudzbaStavka_OnlineNarudzba_OnlineNarudzbaID",
                table: "NarudzbaStavka",
                column: "OnlineNarudzbaID",
                principalTable: "OnlineNarudzba",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacije_OnlineGost_OnlineGostID",
                table: "Notifikacije",
                column: "OnlineGostID",
                principalTable: "OnlineGost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineNarudzba_DostavaNalog_DostavaNalogID",
                table: "OnlineNarudzba",
                column: "DostavaNalogID",
                principalTable: "DostavaNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PonudaStavka_DnevnaPonuda_DnevnaPonudaID",
                table: "PonudaStavka",
                column: "DnevnaPonudaID",
                principalTable: "DnevnaPonuda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PonudaStavka_Meni_MeniID",
                table: "PonudaStavka",
                column: "MeniID",
                principalTable: "Meni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RezervacijaStolova_OnlineGost_OnlineGostID",
                table: "RezervacijaStolova",
                column: "OnlineGostID",
                principalTable: "OnlineGost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaUlaza_Meni_MeniID",
                table: "StavkaUlaza",
                column: "MeniID",
                principalTable: "Meni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaUlaza_UlazUSkladiste_UlazUSkladisteID",
                table: "StavkaUlaza",
                column: "UlazUSkladisteID",
                principalTable: "UlazUSkladiste",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UlazUSkladiste_Uposleniks_UposlenikID",
                table: "UlazUSkladiste",
                column: "UposlenikID",
                principalTable: "Uposleniks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uposleniks_Restoran_RestoranID",
                table: "Uposleniks",
                column: "RestoranID",
                principalTable: "Restoran",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DostavaNalog_Uposleniks_UposlenikID",
                table: "DostavaNalog");

            migrationBuilder.DropForeignKey(
                name: "FK_DostavaNalog_VoziloZaDostavu_VoziloZaDostavuID",
                table: "DostavaNalog");

            migrationBuilder.DropForeignKey(
                name: "FK_Meni_Kategorija_KategorijaID",
                table: "Meni");

            migrationBuilder.DropForeignKey(
                name: "FK_NarudzbaStavka_DnevnaPonuda_DnevnaPonudaID",
                table: "NarudzbaStavka");

            migrationBuilder.DropForeignKey(
                name: "FK_NarudzbaStavka_Meni_MeniID",
                table: "NarudzbaStavka");

            migrationBuilder.DropForeignKey(
                name: "FK_NarudzbaStavka_OnlineNarudzba_OnlineNarudzbaID",
                table: "NarudzbaStavka");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacije_OnlineGost_OnlineGostID",
                table: "Notifikacije");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineNarudzba_DostavaNalog_DostavaNalogID",
                table: "OnlineNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_PonudaStavka_DnevnaPonuda_DnevnaPonudaID",
                table: "PonudaStavka");

            migrationBuilder.DropForeignKey(
                name: "FK_PonudaStavka_Meni_MeniID",
                table: "PonudaStavka");

            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_OnlineGost_OnlineGostID",
                table: "RezervacijaStolova");

            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_Stol_StolID",
                table: "RezervacijaStolova");

            migrationBuilder.DropForeignKey(
                name: "FK_RezervacijaStolova_Uposleniks_UposlenikID",
                table: "RezervacijaStolova");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaUlaza_Meni_MeniID",
                table: "StavkaUlaza");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaUlaza_UlazUSkladiste_UlazUSkladisteID",
                table: "StavkaUlaza");

            migrationBuilder.DropForeignKey(
                name: "FK_UlazUSkladiste_Uposleniks_UposlenikID",
                table: "UlazUSkladiste");

            migrationBuilder.DropForeignKey(
                name: "FK_Uposleniks_Restoran_RestoranID",
                table: "Uposleniks");

            migrationBuilder.DropIndex(
                name: "IX_Uposleniks_RestoranID",
                table: "Uposleniks");

            migrationBuilder.DropIndex(
                name: "IX_UlazUSkladiste_UposlenikID",
                table: "UlazUSkladiste");

            migrationBuilder.DropIndex(
                name: "IX_StavkaUlaza_MeniID",
                table: "StavkaUlaza");

            migrationBuilder.DropIndex(
                name: "IX_StavkaUlaza_UlazUSkladisteID",
                table: "StavkaUlaza");

            migrationBuilder.DropIndex(
                name: "IX_RezervacijaStolova_OnlineGostID",
                table: "RezervacijaStolova");

            migrationBuilder.DropIndex(
                name: "IX_RezervacijaStolova_StolID",
                table: "RezervacijaStolova");

            migrationBuilder.DropIndex(
                name: "IX_RezervacijaStolova_UposlenikID",
                table: "RezervacijaStolova");

            migrationBuilder.DropIndex(
                name: "IX_PonudaStavka_DnevnaPonudaID",
                table: "PonudaStavka");

            migrationBuilder.DropIndex(
                name: "IX_PonudaStavka_MeniID",
                table: "PonudaStavka");

            migrationBuilder.DropIndex(
                name: "IX_OnlineNarudzba_DostavaNalogID",
                table: "OnlineNarudzba");

            migrationBuilder.DropIndex(
                name: "IX_Notifikacije_OnlineGostID",
                table: "Notifikacije");

            migrationBuilder.DropIndex(
                name: "IX_NarudzbaStavka_DnevnaPonudaID",
                table: "NarudzbaStavka");

            migrationBuilder.DropIndex(
                name: "IX_NarudzbaStavka_MeniID",
                table: "NarudzbaStavka");

            migrationBuilder.DropIndex(
                name: "IX_NarudzbaStavka_OnlineNarudzbaID",
                table: "NarudzbaStavka");

            migrationBuilder.DropIndex(
                name: "IX_Meni_KategorijaID",
                table: "Meni");

            migrationBuilder.DropIndex(
                name: "IX_DostavaNalog_UposlenikID",
                table: "DostavaNalog");

            migrationBuilder.DropIndex(
                name: "IX_DostavaNalog_VoziloZaDostavuID",
                table: "DostavaNalog");

            migrationBuilder.DropColumn(
                name: "RestoranID",
                table: "Uposleniks");

            migrationBuilder.DropColumn(
                name: "UposlenikID",
                table: "UlazUSkladiste");

            migrationBuilder.DropColumn(
                name: "MeniID",
                table: "StavkaUlaza");

            migrationBuilder.DropColumn(
                name: "UlazUSkladisteID",
                table: "StavkaUlaza");

            migrationBuilder.DropColumn(
                name: "OnlineGostID",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "StolID",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "UposlenikID",
                table: "RezervacijaStolova");

            migrationBuilder.DropColumn(
                name: "DnevnaPonudaID",
                table: "PonudaStavka");

            migrationBuilder.DropColumn(
                name: "MeniID",
                table: "PonudaStavka");

            migrationBuilder.DropColumn(
                name: "DostavaNalogID",
                table: "OnlineNarudzba");

            migrationBuilder.DropColumn(
                name: "OnlineGostID",
                table: "Notifikacije");

            migrationBuilder.DropColumn(
                name: "DnevnaPonudaID",
                table: "NarudzbaStavka");

            migrationBuilder.DropColumn(
                name: "MeniID",
                table: "NarudzbaStavka");

            migrationBuilder.DropColumn(
                name: "OnlineNarudzbaID",
                table: "NarudzbaStavka");

            migrationBuilder.DropColumn(
                name: "KategorijaID",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "UposlenikID",
                table: "DostavaNalog");

            migrationBuilder.DropColumn(
                name: "VoziloZaDostavuID",
                table: "DostavaNalog");

            migrationBuilder.AddColumn<int>(
                name: "DostavaNalogID",
                table: "VoziloZaDostavu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DostavaNalogId",
                table: "Uposleniks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RezervacijaStolovaId",
                table: "Uposleniks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UlazUSkladisteID",
                table: "Uposleniks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StavkaUlazaId",
                table: "UlazUSkladiste",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RezervacijaStolovaID",
                table: "Stol",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UposlenikID",
                table: "Restoran",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NarudzbaStavkaID",
                table: "OnlineNarudzba",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotifikacijeId",
                table: "OnlineGost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RezervacijaStolovaId",
                table: "OnlineGost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NarudzbaStavkaID",
                table: "Meni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PonudaStavkaID",
                table: "Meni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StavkaUlazaID",
                table: "Meni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeniID",
                table: "Kategorija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnlineNarudzbaID",
                table: "DostavaNalog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PonudaStavkaId",
                table: "DnevnaPonuda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoziloZaDostavu_DostavaNalogID",
                table: "VoziloZaDostavu",
                column: "DostavaNalogID");

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
                name: "IX_UlazUSkladiste_StavkaUlazaId",
                table: "UlazUSkladiste",
                column: "StavkaUlazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Stol_RezervacijaStolovaID",
                table: "Stol",
                column: "RezervacijaStolovaID");

            migrationBuilder.CreateIndex(
                name: "IX_Restoran_UposlenikID",
                table: "Restoran",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineNarudzba_NarudzbaStavkaID",
                table: "OnlineNarudzba",
                column: "NarudzbaStavkaID");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineGost_NotifikacijeId",
                table: "OnlineGost",
                column: "NotifikacijeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineGost_RezervacijaStolovaId",
                table: "OnlineGost",
                column: "RezervacijaStolovaId");

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
                name: "IX_Kategorija_MeniID",
                table: "Kategorija",
                column: "MeniID");

            migrationBuilder.CreateIndex(
                name: "IX_DostavaNalog_OnlineNarudzbaID",
                table: "DostavaNalog",
                column: "OnlineNarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_DnevnaPonuda_PonudaStavkaId",
                table: "DnevnaPonuda",
                column: "PonudaStavkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DnevnaPonuda_PonudaStavka_PonudaStavkaId",
                table: "DnevnaPonuda",
                column: "PonudaStavkaId",
                principalTable: "PonudaStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DostavaNalog_OnlineNarudzba_OnlineNarudzbaID",
                table: "DostavaNalog",
                column: "OnlineNarudzbaID",
                principalTable: "OnlineNarudzba",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kategorija_Meni_MeniID",
                table: "Kategorija",
                column: "MeniID",
                principalTable: "Meni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meni_NarudzbaStavka_NarudzbaStavkaID",
                table: "Meni",
                column: "NarudzbaStavkaID",
                principalTable: "NarudzbaStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meni_PonudaStavka_PonudaStavkaID",
                table: "Meni",
                column: "PonudaStavkaID",
                principalTable: "PonudaStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meni_StavkaUlaza_StavkaUlazaID",
                table: "Meni",
                column: "StavkaUlazaID",
                principalTable: "StavkaUlaza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineGost_Notifikacije_NotifikacijeId",
                table: "OnlineGost",
                column: "NotifikacijeId",
                principalTable: "Notifikacije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineGost_RezervacijaStolova_RezervacijaStolovaId",
                table: "OnlineGost",
                column: "RezervacijaStolovaId",
                principalTable: "RezervacijaStolova",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineNarudzba_NarudzbaStavka_NarudzbaStavkaID",
                table: "OnlineNarudzba",
                column: "NarudzbaStavkaID",
                principalTable: "NarudzbaStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restoran_Uposleniks_UposlenikID",
                table: "Restoran",
                column: "UposlenikID",
                principalTable: "Uposleniks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stol_RezervacijaStolova_RezervacijaStolovaID",
                table: "Stol",
                column: "RezervacijaStolovaID",
                principalTable: "RezervacijaStolova",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UlazUSkladiste_StavkaUlaza_StavkaUlazaId",
                table: "UlazUSkladiste",
                column: "StavkaUlazaId",
                principalTable: "StavkaUlaza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uposleniks_DostavaNalog_DostavaNalogId",
                table: "Uposleniks",
                column: "DostavaNalogId",
                principalTable: "DostavaNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uposleniks_RezervacijaStolova_RezervacijaStolovaId",
                table: "Uposleniks",
                column: "RezervacijaStolovaId",
                principalTable: "RezervacijaStolova",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uposleniks_UlazUSkladiste_UlazUSkladisteID",
                table: "Uposleniks",
                column: "UlazUSkladisteID",
                principalTable: "UlazUSkladiste",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoziloZaDostavu_DostavaNalog_DostavaNalogID",
                table: "VoziloZaDostavu",
                column: "DostavaNalogID",
                principalTable: "DostavaNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
