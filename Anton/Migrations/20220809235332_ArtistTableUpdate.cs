using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anton.Migrations
{
    public partial class ArtistTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "street",
                table: "Artist");
        }
    }
}
