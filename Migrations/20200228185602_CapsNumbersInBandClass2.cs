using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordCompany.Migrations
{
    public partial class CapsNumbersInBandClass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembersOfMembers",
                table: "Band");

            migrationBuilder.AddColumn<int>(
                name: "NumbersOfMembers",
                table: "Band",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumbersOfMembers",
                table: "Band");

            migrationBuilder.AddColumn<int>(
                name: "MembersOfMembers",
                table: "Band",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
