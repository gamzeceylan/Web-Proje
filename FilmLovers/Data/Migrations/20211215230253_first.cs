using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmLovers.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DilAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dizi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiziAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yil = table.Column<int>(type: "int", nullable: true),
                    YazarPuan = table.Column<double>(type: "float", nullable: false),
                    Oyuncular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DilId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dizi_Dil_DilId",
                        column: x => x.DilId,
                        principalTable: "Dil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dizi_Yazar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yil = table.Column<int>(type: "int", nullable: true),
                    Uzunluk = table.Column<int>(type: "int", nullable: true),
                    IMDB_Puan = table.Column<double>(type: "float", nullable: true),
                    Oyuncular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GosterimBaslangıc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GosterimBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarPuan = table.Column<double>(type: "float", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    DilId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Film_Dil_DilId",
                        column: x => x.DilId,
                        principalTable: "Dil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Yazar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Haber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haber_Yazar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roportaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Konusmaci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roportaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roportaj_Yazar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dizi_DilId",
                table: "Dizi",
                column: "DilId");

            migrationBuilder.CreateIndex(
                name: "IX_Dizi_YazarId",
                table: "Dizi",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_DilId",
                table: "Film",
                column: "DilId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_KategoriId",
                table: "Film",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_YazarId",
                table: "Film",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Haber_YazarId",
                table: "Haber",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Roportaj_YazarId",
                table: "Roportaj",
                column: "YazarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dizi");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Haber");

            migrationBuilder.DropTable(
                name: "Roportaj");

            migrationBuilder.DropTable(
                name: "Dil");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Yazar");
        }
    }
}
