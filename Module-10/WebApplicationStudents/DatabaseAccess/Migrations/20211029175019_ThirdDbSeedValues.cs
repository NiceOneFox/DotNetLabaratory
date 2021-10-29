using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class ThirdDbSeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceDb_Lectures_LectureId",
                table: "AttendanceDb");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceDb_Students_StudentId",
                table: "AttendanceDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendanceDb",
                table: "AttendanceDb");

            migrationBuilder.RenameTable(
                name: "AttendanceDb",
                newName: "Attendances");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceDb_StudentId",
                table: "Attendances",
                newName: "IX_Attendances_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                columns: new[] { "LectureId", "StudentId" });

            migrationBuilder.InsertData(
                table: "Lectors",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, "irina.vlasova@mail.ru", "Irina", "Vlasova", "Lector" },
                    { 2, "viktor.bolshov@mail.ru", "Viktor", "Bolshov", "Main lector" },
                    { 3, "vlad.gryaznov@mail.ru", "Vlad", "Gryaznov", "Lector" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Email", "FirstName", "LastName", "Score" },
                values: new object[,]
                {
                    { 1, 24, "oleg.leskov@mail.ru", "Oleg", "Leskov", 0 },
                    { 2, 22, "ivan.ivanovich@mail.ru", "Ivan", "Ivanovich", 0 },
                    { 3, 21, "egor.sizlov@mail.ru", "Egor", "Sizlov", 0 }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "Date", "LectorId", "Name" },
                values: new object[] { 1, new DateTime(2021, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Docker" });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "Date", "LectorId", "Name" },
                values: new object[] { 2, new DateTime(2021, 11, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, "SOLID" });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "LectureId", "StudentId", "isAttend" },
                values: new object[,]
                {
                    { 1, 1, true },
                    { 1, 2, true },
                    { 1, 3, true },
                    { 2, 1, true },
                    { 2, 2, false },
                    { 2, 3, false }
                });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "Id", "DeadLine", "LectureId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, "Do homework and read book p. 45" },
                    { 2, new DateTime(2021, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "Read article and book p. 65" }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "LectureId", "Mark", "StudentId", "Text" },
                values: new object[,]
                {
                    { 1, 1, 4, 2, "Little mistakes" },
                    { 3, 1, 3, 1, "Too simple" },
                    { 5, 1, 0, 3, "Didn't come to lecture" },
                    { 2, 2, 5, 2, "Great work" },
                    { 4, 2, 5, 1, "Great work" },
                    { 6, 2, 5, 3, "Great work" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Lectures_LectureId",
                table: "Attendances",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Lectures_LectureId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lectors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lectors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lectors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "AttendanceDb");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentId",
                table: "AttendanceDb",
                newName: "IX_AttendanceDb_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendanceDb",
                table: "AttendanceDb",
                columns: new[] { "LectureId", "StudentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceDb_Lectures_LectureId",
                table: "AttendanceDb",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceDb_Students_StudentId",
                table: "AttendanceDb",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
