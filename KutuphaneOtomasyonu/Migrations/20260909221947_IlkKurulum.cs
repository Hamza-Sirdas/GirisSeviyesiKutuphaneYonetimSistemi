using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class IlkKurulum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Raflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RafKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raflar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StokAdedi = table.Column<int>(type: "int", nullable: false),
                    RafId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Raflar_RafId",
                        column: x => x.RafId,
                        principalTable: "Raflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emanetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    UyeId = table.Column<int>(type: "int", nullable: false),
                    AlisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeslimEdildiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emanetler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emanetler_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emanetler_Uyeler_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uyeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emanetler_KitapId",
                table: "Emanetler",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Emanetler_UyeId",
                table: "Emanetler",
                column: "UyeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_RafId",
                table: "Kitaplar",
                column: "RafId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emanetler");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "Raflar");
        }
    }
}
