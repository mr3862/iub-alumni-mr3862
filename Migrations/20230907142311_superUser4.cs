using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class superUser4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99886bd1-367a-489f-9164-5ee2faaaa9ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b70d247e-50ad-44f1-8510-ac10b4045322");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1",
                column: "ConcurrencyStamp",
                value: "58a83d68-3f22-493d-af42-12e59c77c58e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "528378c8-5196-4139-a372-963676616fce", "c267eced-61d2-4a8b-b51e-c39c3f2882ed", "Basic", null },
                    { "ea1347e5-fdec-4527-81dd-0ecc33faee5b", "11baaa3f-b3b2-4b0b-8076-349f69236fa3", "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd243dc6-7120-4fbf-83ea-c2bafd75bcaf", "SUPERADMIN@AAINA.ORG", "AQAAAAEAACcQAAAAEIZI0Y1b+t7iqHvtwb2JdrRR+05AA6bbQnFWxKt+KEHdQPNVsmaYZEHcJT0z7LAhwg==", "ec0719a1-878f-4605-8ebd-8e5dbfec2a34" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528378c8-5196-4139-a372-963676616fce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea1347e5-fdec-4527-81dd-0ecc33faee5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1",
                column: "ConcurrencyStamp",
                value: "2fca20ac-0725-499d-9b92-634ce0559ed0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "99886bd1-367a-489f-9164-5ee2faaaa9ed", "58bc13e8-3eb2-476f-8721-31952f4a903d", "Admin", null },
                    { "b70d247e-50ad-44f1-8510-ac10b4045322", "a42e18bd-556e-47cc-a24c-e7b57aecce2c", "Basic", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a738ab2-72ba-4a3a-9082-5ed87949b48b", null, "AQAAAAEAACcQAAAAEBH32tVswhILXbqo03WP4A7gmaw1DE9EPNiygtxx/X+J0ZDJys3m0KF+6WIJZfU1IQ==", "ea42358a-9b43-477e-b6e1-070406073b6e" });
        }
    }
}
