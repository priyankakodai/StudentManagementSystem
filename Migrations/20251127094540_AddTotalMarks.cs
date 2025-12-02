using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalMarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Marks");

            migrationBuilder.RenameColumn(
                name: "Mark",
                table: "Marks",
                newName: "TotalMarks");

            migrationBuilder.AddColumn<int>(
                name: "English",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Maths",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Science",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Social",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tamil",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "English",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "Maths",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "Science",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "Social",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "Tamil",
                table: "Marks");

            migrationBuilder.RenameColumn(
                name: "TotalMarks",
                table: "Marks",
                newName: "Mark");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Marks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
