using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaveifyData.Migrations
{
    /// <inheritdoc />
    public partial class AddCreationDateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Playlists",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Playlists");
        }
    }
}
