using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class novaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PretragaIspit",
                columns: table => new
                {
                    PretragaIspitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaProizvodaId = table.Column<int>(type: "int", nullable: true),
                    KupacId = table.Column<int>(type: "int", nullable: true),
                    MinIznosPrometa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatumOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumDO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IznosPrometa = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PretragaIspit", x => x.PretragaIspitId);
                    table.ForeignKey(
                        name: "FK_PretragaIspit_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PretragaIspit_VrsteProizvoda_VrstaProizvodaId",
                        column: x => x.VrstaProizvodaId,
                        principalTable: "VrsteProizvoda",
                        principalColumn: "VrstaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Narudzbe",
                columns: new[] { "NarudzbaID", "BrojNarudzbe", "Datum", "KupacID", "Otkazano", "Status" },
                values: new object[,]
                {
                    { 1, "aaa", new DateTime(2022, 3, 30, 20, 58, 17, 970, DateTimeKind.Local).AddTicks(5153), 1, false, true },
                    { 2, "bbb", new DateTime(2022, 3, 30, 20, 58, 17, 970, DateTimeKind.Local).AddTicks(6655), 1, false, true },
                    { 3, "ccc", new DateTime(2022, 3, 30, 20, 58, 17, 970, DateTimeKind.Local).AddTicks(6772), 2, false, true },
                    { 4, "ddd", new DateTime(2022, 3, 30, 20, 58, 17, 970, DateTimeKind.Local).AddTicks(6841), 2, false, true }
                });

            migrationBuilder.InsertData(
                table: "PretragaIspit",
                columns: new[] { "PretragaIspitId", "DatumDO", "DatumOD", "IznosPrometa", "KupacId", "MinIznosPrometa", "VrstaProizvodaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 30, 20, 58, 17, 972, DateTimeKind.Local).AddTicks(33), new DateTime(2022, 3, 20, 20, 58, 17, 972, DateTimeKind.Local).AddTicks(511), 242m, 1, 10m, 1 },
                    { 2, new DateTime(2022, 3, 30, 20, 58, 17, 972, DateTimeKind.Local).AddTicks(2580), new DateTime(2022, 3, 20, 20, 58, 17, 972, DateTimeKind.Local).AddTicks(2610), 2421m, 2, 10m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Izlazi",
                columns: new[] { "IzlazID", "BrojRacuna", "Datum", "IznosBezPDV", "IznosSaPDV", "KorisnikID", "NarudzbaID", "SkladisteID", "Zakljucen" },
                values: new object[,]
                {
                    { 1, "aaa", new DateTime(2022, 3, 30, 20, 58, 17, 961, DateTimeKind.Local).AddTicks(4863), 550m, 580m, 1, 1, 1, false },
                    { 2, "bbb", new DateTime(2022, 3, 30, 20, 58, 17, 970, DateTimeKind.Local).AddTicks(2024), 550m, 580m, 1, 1, 1, false }
                });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkaID", "Kolicina", "NarudzbaID", "ProizvodID" },
                values: new object[,]
                {
                    { 1, 4, 1, 1 },
                    { 2, 2, 1, 1 },
                    { 3, 4, 3, 4 },
                    { 4, 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "IzlazStavke",
                columns: new[] { "IzlazStavkaID", "Cijena", "IzlazID", "Kolicina", "Popust", "ProizvodID" },
                values: new object[] { 1, 450m, 1, 2, 6m, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_PretragaIspit_KupacId",
                table: "PretragaIspit",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_PretragaIspit_VrstaProizvodaId",
                table: "PretragaIspit",
                column: "VrstaProizvodaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PretragaIspit");

            migrationBuilder.DeleteData(
                table: "IzlazStavke",
                keyColumn: "IzlazStavkaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1);
        }
    }
}
