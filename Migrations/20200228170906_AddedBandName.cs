using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordCompany.Migrations
{
    public partial class AddedBandName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Song",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Band",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Band",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BandId",
                table: "Album",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SongID",
                table: "Album",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Band_AlbumId",
                table: "Band",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_BandId",
                table: "Album",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_SongID",
                table: "Album",
                column: "SongID");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Band_BandId",
                table: "Album",
                column: "BandId",
                principalTable: "Band",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Band_BandId",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Album_Song_SongID",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Band_Album_AlbumId",
                table: "Band");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_AlbumId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Band_AlbumId",
                table: "Band");

            migrationBuilder.DropIndex(
                name: "IX_Album_BandId",
                table: "Album");

            migrationBuilder.DropIndex(
                name: "IX_Album_SongID",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Band");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Band");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "SongID",
                table: "Album");
        }
    }
}
