using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___LINQ.Migrations
{
    public partial class addedteacherclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TeacherID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TeacherID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "TeacherClassesTeacherClassID",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TeacherClasses",
                columns: table => new
                {
                    TeacherClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherClasses", x => x.TeacherClassID);
                });

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
                name: "IX_Classes_TeacherClassesTeacherClassID",
                table: "Classes",
                column: "TeacherClassesTeacherClassID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherTeacherClass_TeachersTeacherID",
                table: "TeacherTeacherClass",
                column: "TeachersTeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_TeacherClasses_TeacherClassesTeacherClassID",
                table: "Classes",
                column: "TeacherClassesTeacherClassID",
                principalTable: "TeacherClasses",
                principalColumn: "TeacherClassID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_TeacherClasses_TeacherClassesTeacherClassID",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "TeacherTeacherClass");

            migrationBuilder.DropTable(
                name: "TeacherClasses");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TeacherClassesTeacherClassID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeacherClassesTeacherClassID",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherID",
                table: "Classes",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_TeacherID",
                table: "Classes",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID");
        }
    }
}
