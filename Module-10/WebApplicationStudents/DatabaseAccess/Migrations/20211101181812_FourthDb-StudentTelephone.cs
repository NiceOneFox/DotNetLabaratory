using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class FourthDbStudentTelephone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isAttend",
                table: "Attendances",
                newName: "IsAttend");

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telephone",
                value: "+7(566)534-96-53");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telephone",
                value: "+7(866)735-46-33");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telephone",
                value: "+7(924)873-01-42");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "IsAttend",
                table: "Attendances",
                newName: "isAttend");
        }
    }
}
