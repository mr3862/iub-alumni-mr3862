using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class superUser5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "31690615-a48e-4d03-a9e1-53c57c11c9ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "66e8d84a-ce79-494b-90ab-9ecfd15e58ab", "207f6cd0-96d1-483b-aed9-30c31c746c95", "Basic", null },
                    { "676847dd-ae48-4e9f-87cc-1ff4df56012d", "d8282871-973e-4e8d-8464-685e136efc82", "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f789e20-4e34-4b27-a672-b50c070a46af", "SUPERADMIN@AAINA.ORG", "AQAAAAEAACcQAAAAEMeILJPr76lxem/5fMOY8dyJYp9t98VE/6vA2snCb5D4aJ+seNHURosT5FYUbcOhnA==", "35fd4775-3d9b-4f29-9409-08684c4cf6f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66e8d84a-ce79-494b-90ab-9ecfd15e58ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "676847dd-ae48-4e9f-87cc-1ff4df56012d");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd243dc6-7120-4fbf-83ea-c2bafd75bcaf", null, "AQAAAAEAACcQAAAAEIZI0Y1b+t7iqHvtwb2JdrRR+05AA6bbQnFWxKt+KEHdQPNVsmaYZEHcJT0z7LAhwg==", "ec0719a1-878f-4605-8ebd-8e5dbfec2a34" });
        }
    }
}
