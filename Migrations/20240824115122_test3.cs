using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employee1");

            migrationBuilder.DropColumn(
                name: "salaries",
                table: "Employee1");

            migrationBuilder.AddColumn<long>(
                name: "salary",
                table: "Employee1",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "salary",
                table: "Employee1");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employee1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "salaries",
                table: "Employee1",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
