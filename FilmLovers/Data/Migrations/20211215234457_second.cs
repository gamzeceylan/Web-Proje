using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmLovers.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Haber",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Afis",
                table: "Film",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Dizi",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Haber");

            migrationBuilder.DropColumn(
                name: "Afis",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Dizi");
        }
    }
}
