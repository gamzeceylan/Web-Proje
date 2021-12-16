using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmLovers.Data.Migrations
{
    public partial class degisiklikler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Roportaj",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Roportaj");
        }
    }
}
