using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class FifthDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Lectors_LectorId",
                table: "Lectures");

            migrationBuilder.RenameColumn(
                name: "LectorId",
                table: "Lectures",
                newName: "SeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Lectures_LectorId",
                table: "Lectures",
                newName: "IX_Lectures_SeriesId");

            migrationBuilder.AddColumn<int>(
                name: "SeriesId",
                table: "Lectors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SeriesDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesDb_Lectors_LectorId",
                        column: x => x.LectorId,
                        principalTable: "Lectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                column: "IsAttend",
                value: true);

            migrationBuilder.UpdateData(
                table: "Lectors",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lectors",
                keyColumn: "Id",
                keyValue: 2,
                column: "SeriesId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Lectors",
                keyColumn: "Id",
                keyValue: 3,
                column: "SeriesId",
                value: 3);

            migrationBuilder.InsertData(
                table: "SeriesDb",
                columns: new[] { "Id", "DateEnd", "DateStart", "LectorId", "Name", "Text" },
                values: new object[,]
                {
                    { 1, null, null, 1, "Base Course of Algorithms and Programming", null },
                    { 2, null, null, 2, "Middle Course of C# programming", null },
                    { 3, null, null, 3, "Advanced course of Algorithms and ML", null }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "Date", "HomeworkId", "Name", "SeriesId" },
                values: new object[] { 3, new DateTime(2021, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Design Patterns", 1 });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "Date", "HomeworkId", "Name", "SeriesId" },
                values: new object[] { 5, new DateTime(2021, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, "Graphics", 1 });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "Date", "HomeworkId", "Name", "SeriesId" },
                values: new object[] { 4, new DateTime(2021, 12, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, "Machine Learning", 3 });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "LectureId", "StudentId", "IsAttend" },
                values: new object[,]
                {
                    { 3, 1, false },
                    { 3, 2, false },
                    { 3, 3, true },
                    { 5, 1, true },
                    { 5, 2, true },
                    { 5, 3, false },
                    { 4, 1, true },
                    { 4, 2, true },
                    { 4, 3, true }
                });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "Id", "DeadLine", "LectureId", "Text" },
                values: new object[] { 3, new DateTime(2021, 12, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, "Ex. 24. First Paragraph" });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesDb_LectorId",
                table: "SeriesDb",
                column: "LectorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_SeriesDb_SeriesId",
                table: "Lectures",
                column: "SeriesId",
                principalTable: "SeriesDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_SeriesDb_SeriesId",
                table: "Lectures");

            migrationBuilder.DropTable(
                name: "SeriesDb");

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "SeriesId",
                table: "Lectors");

            migrationBuilder.RenameColumn(
                name: "SeriesId",
                table: "Lectures",
                newName: "LectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Lectures_SeriesId",
                table: "Lectures",
                newName: "IX_Lectures_LectorId");

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumns: new[] { "LectureId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                column: "IsAttend",
                value: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Lectors_LectorId",
                table: "Lectures",
                column: "LectorId",
                principalTable: "Lectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
