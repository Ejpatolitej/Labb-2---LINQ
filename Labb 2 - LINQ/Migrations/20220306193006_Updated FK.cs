using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___LINQ.Migrations
{
    public partial class UpdatedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fkClassID",
                table: "TeacherClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fkTeacherID",
                table: "TeacherClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fkClassID",
                table: "CourseClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fkCourseID",
                table: "CourseClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fkClassID",
                table: "TeacherClasses");

            migrationBuilder.DropColumn(
                name: "fkTeacherID",
                table: "TeacherClasses");

            migrationBuilder.DropColumn(
                name: "fkClassID",
                table: "CourseClasses");

            migrationBuilder.DropColumn(
                name: "fkCourseID",
                table: "CourseClasses");
        }
    }
}
