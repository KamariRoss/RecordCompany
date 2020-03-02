using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordCompany.Migrations
{
    public partial class CorrectTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Song_SongID",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Band_Album_AlbumId",
                table: "Band");

            migrationBuilder.DropIndex(
                name: "IX_Band_AlbumId",
                table: "Band");

            migrationBuilder.DropIndex(
                name: "IX_Album_SongID",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Band");

            migrationBuilder.DropColumn(
                name: "SongID",
                table: "Album");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Band",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SongID",
                table: "Album",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Band_AlbumId",
                table: "Band",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_SongID",
                table: "Album",
                column: "SongID");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Song_SongID",
                table: "Album",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Band_Album_AlbumId",
                table: "Band",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
