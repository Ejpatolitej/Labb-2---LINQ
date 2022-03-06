using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___LINQ.Migrations
{
    public partial class UpdatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_CourseClasses_CourseClassID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_TeacherClasses_TeacherClassesTeacherClassID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseClasses_CourseClassID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "TeacherTeacherClass");

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
                name: "IX_Classes_TeacherClassesTeacherClassID",
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
                name: "TeacherClassesTeacherClassID",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "fkTeacherID",
                table: "TeacherClasses",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "fkClassID",
                table: "TeacherClasses",
                newName: "ClassID");

            migrationBuilder.RenameColumn(
                name: "fkCourseID",
                table: "CourseClasses",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "fkClassID",
                table: "CourseClasses",
                newName: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClasses_ClassID",
                table: "TeacherClasses",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClasses_TeacherID",
                table: "TeacherClasses",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseClasses_ClassID",
                table: "CourseClasses",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseClasses_CourseID",
                table: "CourseClasses",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseClasses_Classes_ClassID",
                table: "CourseClasses",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseClasses_Courses_CourseID",
                table: "CourseClasses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherClasses_Classes_ClassID",
                table: "TeacherClasses",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherClasses_Teachers_TeacherID",
                table: "TeacherClasses",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseClasses_Classes_ClassID",
                table: "CourseClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseClasses_Courses_CourseID",
                table: "CourseClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherClasses_Classes_ClassID",
                table: "TeacherClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherClasses_Teachers_TeacherID",
                table: "TeacherClasses");

            migrationBuilder.DropIndex(
                name: "IX_TeacherClasses_ClassID",
                table: "TeacherClasses");

            migrationBuilder.DropIndex(
                name: "IX_TeacherClasses_TeacherID",
                table: "TeacherClasses");

            migrationBuilder.DropIndex(
                name: "IX_CourseClasses_ClassID",
                table: "CourseClasses");

            migrationBuilder.DropIndex(
                name: "IX_CourseClasses_CourseID",
                table: "CourseClasses");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "TeacherClasses",
                newName: "fkTeacherID");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "TeacherClasses",
                newName: "fkClassID");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "CourseClasses",
                newName: "fkCourseID");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "CourseClasses",
                newName: "fkClassID");

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
                name: "TeacherClassesTeacherClassID",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TeacherTeacherClass",
                columns: table => new
                {
                    TeacherClassesTeacherClassID = table.Column<int>(type: "int", nullable: false),
                    TeachersTeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherTeacherClass", x => new { x.TeacherClassesTeacherClassID, x.TeachersTeacherID });
                    table.ForeignKey(
                        name: "FK_TeacherTeacherClass_TeacherClasses_TeacherClassesTeacherClassID",
                        column: x => x.TeacherClassesTeacherClassID,
                        principalTable: "TeacherClasses",
                        principalColumn: "TeacherClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherTeacherClass_Teachers_TeachersTeacherID",
                        column: x => x.TeachersTeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Classes_TeacherClassesTeacherClassID",
                table: "Classes",
                column: "TeacherClassesTeacherClassID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherTeacherClass_TeachersTeacherID",
                table: "TeacherTeacherClass",
                column: "TeachersTeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_CourseClasses_CourseClassID",
                table: "Classes",
                column: "CourseClassID",
                principalTable: "CourseClasses",
                principalColumn: "CourseClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_TeacherClasses_TeacherClassesTeacherClassID",
                table: "Classes",
                column: "TeacherClassesTeacherClassID",
                principalTable: "TeacherClasses",
                principalColumn: "TeacherClassID",
                onDelete: ReferentialAction.Cascade);

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
    }
}
