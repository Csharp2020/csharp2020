using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pred_nastavnik",
                columns: table => new
                {
                    SifNastavnik = table.Column<int>(nullable: false),
                    SifPred = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pred_nastavnik", x => new { x.SifNastavnik, x.SifPred });
                    table.ForeignKey(
                        name: "FK_pred_nastavnik_nastavnik_SifNastavnik",
                        column: x => x.SifNastavnik,
                        principalTable: "nastavnik",
                        principalColumn: "sifNastavnik",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pred_nastavnik_pred_SifPred",
                        column: x => x.SifPred,
                        principalTable: "pred",
                        principalColumn: "sifPred",
                        onDelete: ReferentialAction.Cascade);

                });
        }

           
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ispit");

            migrationBuilder.DropTable(
                name: "pred_nastavnik");

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
