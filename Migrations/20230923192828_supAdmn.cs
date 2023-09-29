using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class supAdmn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fb953da-3ab4-4562-8721-5eaa2e36b221");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13fef42-24ce-40a5-b03a-249fac113fa7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ec9d32a5-9f07-48f2-81e7-34a32d1d0214");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1287f9d8-797a-4e7c-9f1a-d21c060a56e8", "7b118498-0603-413e-93be-f20bcc085f0e", "Basic", "BASIC" },
                    { "71d6e36b-9f0b-46ff-8b1b-68924c500aad", "2997553c-06f2-4747-a134-2ce62dcdb263", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "332549c2-a52f-46e0-98a4-d97c9c1a00e1", "mr3862@columbia.edu", "MR3862@COLUMBIA.EDU", "MR3862", "AQAAAAEAACcQAAAAEDk7sdfecPLrej16losyRC8U8AalwFQ0n42ITmy9Ccmyh8YVskBHkMEDTE6XKty0SQ==", "25c01cc1-623e-4fbd-93eb-16c37a0eb960", "mr3862" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1287f9d8-797a-4e7c-9f1a-d21c060a56e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71d6e36b-9f0b-46ff-8b1b-68924c500aad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1d7b4dc0-31de-422d-9775-b5250ad190fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fb953da-3ab4-4562-8721-5eaa2e36b221", "265dfaa2-9b01-4181-8210-a604f24905d5", "Admin", "ADMIN" },
                    { "b13fef42-24ce-40a5-b03a-249fac113fa7", "d6a589f0-4c1b-46d5-b20a-3310bda4c991", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5b9a9373-a87f-4fef-8718-05f46c42f8dc", "SuperAdmin@aaina.org", "SUPERADMIN@AAINA.ORG", "SUPERADMIN@AAINA.ORG", "AQAAAAEAACcQAAAAEPuPuP7ooEANEVlqG97l8DMfPwFdtIxtw/u73f3E9/ShQWgbT8hLLdPKyF0UKbL04A==", "f9176fff-1757-4d18-91ab-828afc263bbc", "SuperAdmin@aaina.org" });
        }
    }
}
