using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMigrationEF.Migrations
{
    public partial class AddNewFieldPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApellidoMaterno",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApellidoMaterno",
                table: "Persons");
        }
    }
}
