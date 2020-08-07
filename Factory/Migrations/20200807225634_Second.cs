using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Machines");

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Machines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Machines");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Machines",
                nullable: false,
                defaultValue: 0);
        }
    }
}
