using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fakultet.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dvorana",
                columns: table => new
                {
                    oznDvorana = table.Column<string>(unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    kapacitet = table.Column<int>(nullable: true, defaultValueSql: "((40))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dvorana", x => x.oznDvorana);
                });

            migrationBuilder.CreateTable(
                name: "orgjed",
                columns: table => new
                {
                    sifOrgjed = table.Column<int>(nullable: false),
                    nazOrgjed = table.Column<string>(fixedLength: true, maxLength: 60, nullable: false),
                    sifNadorgjed = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgjed", x => x.sifOrgjed);
                    table.ForeignKey(
                        name: "FK_orgjed_orgjed",
                        column: x => x.sifNadorgjed,
                        principalTable: "orgjed",
                        principalColumn: "sifOrgjed",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "zupanija",
                columns: table => new
                {
                    sifZupanija = table.Column<short>(nullable: false),
                    nazZupanija = table.Column<string>(fixedLength: true, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zupanija", x => x.sifZupanija);
                });

            migrationBuilder.CreateTable(
                name: "pred",
                columns: table => new
                {
                    sifPred = table.Column<int>(nullable: false),
                    kratPred = table.Column<string>(unicode: false, fixedLength: true, maxLength: 8, nullable: true),
                    nazPred = table.Column<string>(fixedLength: true, maxLength: 60, nullable: false),
                    sifOrgjed = table.Column<int>(nullable: true),
                    upisanoStud = table.Column<int>(nullable: true),
                    brojSatiTjedno = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pred", x => x.sifPred);
                    table.ForeignKey(
                        name: "FK_pred_orgjed",
                        column: x => x.sifOrgjed,
                        principalTable: "orgjed",
                        principalColumn: "sifOrgjed",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mjesto",
                columns: table => new
                {
                    pbr = table.Column<int>(nullable: false),
                    nazMjesto = table.Column<string>(fixedLength: true, maxLength: 40, nullable: false),
                    sifZupanija = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mjesto", x => x.pbr);
                    table.ForeignKey(
                        name: "FK_mjesto_zupanija",
                        column: x => x.sifZupanija,
                        principalTable: "zupanija",
                        principalColumn: "sifZupanija",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rezervacija",
                columns: table => new
                {
                    oznDvorana = table.Column<string>(unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    oznVrstaDan = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    sat = table.Column<short>(nullable: false),
                    sifPred = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_rezervacija_dvorana",
                        column: x => x.oznDvorana,
                        principalTable: "dvorana",
                        principalColumn: "oznDvorana",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rezervacija_pred",
                        column: x => x.sifPred,
                        principalTable: "pred",
                        principalColumn: "sifPred",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nastavnik",
                columns: table => new
                {
                    sifNastavnik = table.Column<int>(nullable: false),
                    imeNastavnik = table.Column<string>(fixedLength: true, maxLength: 25, nullable: false),
                    prezNastavnik = table.Column<string>(fixedLength: true, maxLength: 25, nullable: false),
                    pbrStan = table.Column<int>(nullable: false),
                    sifOrgjed = table.Column<int>(nullable: false),
                    koef = table.Column<decimal>(type: "decimal(3, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nastavnik", x => x.sifNastavnik);
                    table.ForeignKey(
                        name: "FK_nastavnik_mjesto",
                        column: x => x.pbrStan,
                        principalTable: "mjesto",
                        principalColumn: "pbr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_nastavnik_orgjed",
                        column: x => x.sifOrgjed,
                        principalTable: "orgjed",
                        principalColumn: "sifOrgjed",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "stud",
                columns: table => new
                {
                    mbrStud = table.Column<int>(nullable: false),
                    imeStud = table.Column<string>(maxLength: 25, nullable: false),
                    prezStud = table.Column<string>(maxLength: 25, nullable: false),
                    pbrRod = table.Column<int>(nullable: true),
                    pbrStan = table.Column<int>(nullable: false),
                    datRodStud = table.Column<DateTime>(type: "datetime", nullable: true),
                    jmbgStud = table.Column<string>(unicode: false, fixedLength: true, maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stud", x => x.mbrStud);
                    table.ForeignKey(
                        name: "FK_stud_mjesto",
                        column: x => x.pbrRod,
                        principalTable: "mjesto",
                        principalColumn: "pbr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_stud_mjesto1",
                        column: x => x.pbrStan,
                        principalTable: "mjesto",
                        principalColumn: "pbr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ispit",
                columns: table => new
                {
                    mbrStud = table.Column<int>(nullable: false),
                    sifPred = table.Column<int>(nullable: false),
                    sifNastavnik = table.Column<int>(nullable: false),
                    datIspit = table.Column<DateTime>(type: "datetime", nullable: false),
                    ocjena = table.Column<short>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ispit_stud",
                        column: x => x.mbrStud,
                        principalTable: "stud",
                        principalColumn: "mbrStud",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ispit_nastavnik",
                        column: x => x.sifNastavnik,
                        principalTable: "nastavnik",
                        principalColumn: "sifNastavnik",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ispit_pred",
                        column: x => x.sifPred,
                        principalTable: "pred",
                        principalColumn: "sifPred",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "dvoranaUnique",
                table: "dvorana",
                column: "oznDvorana",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ispit_mbrStud",
                table: "ispit",
                column: "mbrStud");

            migrationBuilder.CreateIndex(
                name: "IX_ispit_sifNastavnik",
                table: "ispit",
                column: "sifNastavnik");

            migrationBuilder.CreateIndex(
                name: "IX_ispit_sifPred",
                table: "ispit",
                column: "sifPred");

            migrationBuilder.CreateIndex(
                name: "mjestoUnique",
                table: "mjesto",
                column: "nazMjesto");

            migrationBuilder.CreateIndex(
                name: "mjestoPbr",
                table: "mjesto",
                column: "pbr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mjesto_sifZupanija",
                table: "mjesto",
                column: "sifZupanija");

            migrationBuilder.CreateIndex(
                name: "IX_nastavnik_pbrStan",
                table: "nastavnik",
                column: "pbrStan");

            migrationBuilder.CreateIndex(
                name: "nastavnikUnique",
                table: "nastavnik",
                column: "sifNastavnik",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nastavnik_sifOrgjed",
                table: "nastavnik",
                column: "sifOrgjed");

            migrationBuilder.CreateIndex(
                name: "IX_orgjed_sifNadorgjed",
                table: "orgjed",
                column: "sifNadorgjed");

            migrationBuilder.CreateIndex(
                name: "orgjedUnique",
                table: "orgjed",
                column: "sifOrgjed",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pred_sifOrgjed",
                table: "pred",
                column: "sifOrgjed");

            migrationBuilder.CreateIndex(
                name: "predUnique",
                table: "pred",
                column: "sifPred",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rezervacija_oznDvorana",
                table: "rezervacija",
                column: "oznDvorana");

            migrationBuilder.CreateIndex(
                name: "IX_rezervacija_sifPred",
                table: "rezervacija",
                column: "sifPred");

            migrationBuilder.CreateIndex(
                name: "studUnique",
                table: "stud",
                column: "mbrStud",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stud_pbrRod",
                table: "stud",
                column: "pbrRod");

            migrationBuilder.CreateIndex(
                name: "IX_stud_pbrStan",
                table: "stud",
                column: "pbrStan");

            migrationBuilder.CreateIndex(
                name: "zupanijaUnique",
                table: "zupanija",
                column: "sifZupanija",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ispit");

            migrationBuilder.DropTable(
                name: "rezervacija");

            migrationBuilder.DropTable(
                name: "stud");

            migrationBuilder.DropTable(
                name: "nastavnik");

            migrationBuilder.DropTable(
                name: "dvorana");

            migrationBuilder.DropTable(
                name: "pred");

            migrationBuilder.DropTable(
                name: "mjesto");

            migrationBuilder.DropTable(
                name: "orgjed");

            migrationBuilder.DropTable(
                name: "zupanija");
        }
    }
}
