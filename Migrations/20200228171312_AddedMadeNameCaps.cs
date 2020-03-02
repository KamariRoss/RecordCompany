using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordCompany.Migrations
{
    public partial class AddedMadeNameCaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Band",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Band",
                newName: "name");
        }
    }
}
