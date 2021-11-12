using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class CourseDbFirstCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LectorDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectorDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LectureDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LectureDb_LectorDb_LectorId",
                        column: x => x.LectorId,
                        principalTable: "LectorDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeworkDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LectureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeworkDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeworkDb_LectureDb_LectureId",
                        column: x => x.LectureId,
                        principalTable: "LectureDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LectureDbStudentDb",
                columns: table => new
                {
                    LecturesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureDbStudentDb", x => new { x.LecturesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_LectureDbStudentDb_LectureDb_LecturesId",
                        column: x => x.LecturesId,
                        principalTable: "LectureDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LectureDbStudentDb_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarkDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LectureId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarkDb_LectureDb_LectureId",
                        column: x => x.LectureId,
                        principalTable: "LectureDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarkDb_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkDb_LectureId",
                table: "HomeworkDb",
                column: "LectureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LectureDb_LectorId",
                table: "LectureDb",
                column: "LectorId");

            migrationBuilder.CreateIndex(
                name: "IX_LectureDbStudentDb_StudentsId",
                table: "LectureDbStudentDb",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkDb_LectureId",
                table: "MarkDb",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkDb_StudentId",
                table: "MarkDb",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeworkDb");

            migrationBuilder.DropTable(
                name: "LectureDbStudentDb");

            migrationBuilder.DropTable(
                name: "MarkDb");

            migrationBuilder.DropTable(
                name: "LectureDb");

            migrationBuilder.DropTable(
                name: "LectorDb");
        }
    }
}
