using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___LINQ.Migrations
{
    public partial class AddedCourseClassData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Classes_ClassID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ClassID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "CourseClassID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseClassID",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseClasses",
                columns: table => new
                {
                    CourseClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseClasses", x => x.CourseClassID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseClassID",
                table: "Courses",
                column: "CourseClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CourseClassID",
                table: "Classes",
                column: "CourseClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherID",
                table: "Classes",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_CourseClasses_CourseClassID",
                table: "Classes",
                column: "CourseClassID",
                principalTable: "CourseClasses",
                principalColumn: "CourseClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_TeacherID",
                table: "Classes",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseClasses_CourseClassID",
                table: "Courses",
                column: "CourseClassID",
                principalTable: "CourseClasses",
                principalColumn: "CourseClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_CourseClasses_CourseClassID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TeacherID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseClasses_CourseClassID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CourseClasses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseClassID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Classes_CourseClassID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TeacherID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "CourseClassID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseClassID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClassID",
                table: "Teachers",
                column: "ClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Classes_ClassID",
                table: "Teachers",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
