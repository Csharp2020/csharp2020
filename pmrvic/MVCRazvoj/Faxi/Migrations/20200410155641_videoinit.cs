using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Faxi.Migrations
{
    public partial class videoinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mediji",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    vrsta = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mediji", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prijatelji",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    prezime = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijatelji", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Evidencije",
                columns: table => new
                {
                    prijatelji_id = table.Column<int>(nullable: false),
                    mediji_id = table.Column<int>(nullable: false),
                    datum_posudbe = table.Column<DateTime>(type: "date", nullable: false),
                    datum_vracanja = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidencije", x => new { x.prijatelji_id, x.mediji_id });
                    table.ForeignKey(
                        name: "FK_Evidencije_Mediji",
                        column: x => x.mediji_id,
                        principalTable: "Mediji",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evidencije_Prijatelji",
                        column: x => x.prijatelji_id,
                        principalTable: "Prijatelji",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evidencije_mediji_id",
                table: "Evidencije",
                column: "mediji_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evidencije");

            migrationBuilder.DropTable(
                name: "Mediji");

            migrationBuilder.DropTable(
                name: "Prijatelji");
        }
    }
}
