using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkysFormsDemo.Migrations
{
    public partial class ChangedToAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarCount",
                table: "Person",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Person",
                newName: "CarCount");
        }
    }
}
