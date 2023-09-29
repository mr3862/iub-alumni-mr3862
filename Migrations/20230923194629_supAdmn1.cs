using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class supAdmn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "46e87efb-6872-43ae-9fc3-b02dd7cd91dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d94b3dcc-ffcb-4fbf-8dfb-83e9c4acb7cc", "87108ae4-6ff7-40b8-99cb-bd34ec843586", "Basic", "BASIC" },
                    { "e596f95f-3b57-4ade-977e-910d9a542f70", "3e90c4b9-dd40-4fa6-9f48-5e9b12c70ef4", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "006ace8c-f236-47a3-ad20-0a150e5e8ac0", "MR3862@COLUMBIA.EDU", "AQAAAAEAACcQAAAAEFSrcoAx04IeeQQzPttUEthyOIEC4p5fdpsXGZsHvjwxQtvHXizP4UDjgr51lqpLHA==", "dfdce904-748c-4e18-bd2e-f124dd8e976b", "mr3862@columbia.edu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d94b3dcc-ffcb-4fbf-8dfb-83e9c4acb7cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e596f95f-3b57-4ade-977e-910d9a542f70");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "332549c2-a52f-46e0-98a4-d97c9c1a00e1", "MR3862", "AQAAAAEAACcQAAAAEDk7sdfecPLrej16losyRC8U8AalwFQ0n42ITmy9Ccmyh8YVskBHkMEDTE6XKty0SQ==", "25c01cc1-623e-4fbd-93eb-16c37a0eb960", "mr3862" });
        }
    }
}
