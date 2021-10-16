using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class FirstVersionDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkDb_LectureDb_LectureId",
                table: "HomeworkDb");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureDb_LectorDb_LectorId",
                table: "LectureDb");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureDbStudentDb_LectureDb_LecturesId",
                table: "LectureDbStudentDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkDb_LectureDb_LectureId",
                table: "MarkDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkDb_Students_StudentId",
                table: "MarkDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MarkDb",
                table: "MarkDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LectureDb",
                table: "LectureDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LectorDb",
                table: "LectorDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkDb",
                table: "HomeworkDb");

            migrationBuilder.RenameTable(
                name: "MarkDb",
                newName: "Marks");

            migrationBuilder.RenameTable(
                name: "LectureDb",
                newName: "Lectures");

            migrationBuilder.RenameTable(
                name: "LectorDb",
                newName: "Lectors");

            migrationBuilder.RenameTable(
                name: "HomeworkDb",
                newName: "Homeworks");

            migrationBuilder.RenameIndex(
                name: "IX_MarkDb_StudentId",
                table: "Marks",
                newName: "IX_Marks_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_MarkDb_LectureId",
                table: "Marks",
                newName: "IX_Marks_LectureId");

            migrationBuilder.RenameIndex(
                name: "IX_LectureDb_LectorId",
                table: "Lectures",
                newName: "IX_Lectures_LectorId");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkDb_LectureId",
                table: "Homeworks",
                newName: "IX_Homeworks_LectureId");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Marks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeadLine",
                table: "Homeworks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Homeworks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marks",
                table: "Marks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lectures",
                table: "Lectures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lectors",
                table: "Lectors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Lectures_LectureId",
                table: "Homeworks",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureDbStudentDb_Lectures_LecturesId",
                table: "LectureDbStudentDb",
                column: "LecturesId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Lectors_LectorId",
                table: "Lectures",
                column: "LectorId",
                principalTable: "Lectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Lectures_LectureId",
                table: "Marks",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Students_StudentId",
                table: "Marks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Lectures_LectureId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureDbStudentDb_Lectures_LecturesId",
                table: "LectureDbStudentDb");

            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Lectors_LectorId",
                table: "Lectures");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Lectures_LectureId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Students_StudentId",
                table: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marks",
                table: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lectures",
                table: "Lectures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lectors",
                table: "Lectors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "DeadLine",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Homeworks");

            migrationBuilder.RenameTable(
                name: "Marks",
                newName: "MarkDb");

            migrationBuilder.RenameTable(
                name: "Lectures",
                newName: "LectureDb");

            migrationBuilder.RenameTable(
                name: "Lectors",
                newName: "LectorDb");

            migrationBuilder.RenameTable(
                name: "Homeworks",
                newName: "HomeworkDb");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_StudentId",
                table: "MarkDb",
                newName: "IX_MarkDb_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_LectureId",
                table: "MarkDb",
                newName: "IX_MarkDb_LectureId");

            migrationBuilder.RenameIndex(
                name: "IX_Lectures_LectorId",
                table: "LectureDb",
                newName: "IX_LectureDb_LectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_LectureId",
                table: "HomeworkDb",
                newName: "IX_HomeworkDb_LectureId");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "MarkDb",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarkDb",
                table: "MarkDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LectureDb",
                table: "LectureDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LectorDb",
                table: "LectorDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkDb",
                table: "HomeworkDb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkDb_LectureDb_LectureId",
                table: "HomeworkDb",
                column: "LectureId",
                principalTable: "LectureDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureDb_LectorDb_LectorId",
                table: "LectureDb",
                column: "LectorId",
                principalTable: "LectorDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureDbStudentDb_LectureDb_LecturesId",
                table: "LectureDbStudentDb",
                column: "LecturesId",
                principalTable: "LectureDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkDb_LectureDb_LectureId",
                table: "MarkDb",
                column: "LectureId",
                principalTable: "LectureDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkDb_Students_StudentId",
                table: "MarkDb",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
