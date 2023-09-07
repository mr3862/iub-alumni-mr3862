using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class superUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8b7105b5-8264-49c4-9020-b3e223369c26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "50214112-35a2-432f-8529-6ea335820717");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "92d9c4ac-973d-49eb-97c2-e4f1eac76a77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2015c04d-a6b6-44eb-8cf1-9008e679a3ae", "SuperAdmin@aaina.org", "AQAAAAEAACcQAAAAELfXhsOSVxALBatjSwk5NXFX0l/7s1zM6f2NePnlESCb0xrDAuiSSdRVSBlJhFiASw==", "682e7eb5-fe95-44fe-a38b-2a3b7e6a29f6", "SuperAdmin@aaina.org" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4d47373a-9676-4209-8c45-b5397db65a8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "257f536b-c44a-4885-828e-0686cf07c4e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7d7fef40-10de-4882-a934-adc21be70ff0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fa17d14d-dd97-4471-a8ae-fe8e9929c038", "superadmin@aaina.org", "AQAAAAEAACcQAAAAENa2Pd73gzOK4XymicqT4MJCNJ36YEe+R3Ld6ksnobgztn4euX99fPTEeHvy5Bv01g==", "293960f4-1450-4208-a215-61b41b9759c7", "SuperAdmin" });
        }
    }
}
