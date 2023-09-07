using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c0e63d9d-f493-49b0-a9b0-b2cf9a1a4f8b", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4619dae8-02da-414d-99f7-f3e2ed3a9467", "0fca8c4a-6898-40d9-ad1d-c57886dc64b7", "Basic", "BASIC" },
                    { "6ca39925-6d8c-40b6-940d-31cab4b1dfcb", "73fe4199-b049-4a17-afd7-58b98ab903cf", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89f19fa-16f3-4b73-a502-c9622122c896", "AQAAAAEAACcQAAAAEA2/VkMyqM7ZjXAEMheJXWOsz19bHopd9c7iJ7ECBqJRrK3rls//HmLjkNP+CGRHxw==", "41842daa-e9bb-4670-9de0-946fb71f0de6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4619dae8-02da-414d-99f7-f3e2ed3a9467");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca39925-6d8c-40b6-940d-31cab4b1dfcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "31690615-a48e-4d03-a9e1-53c57c11c9ee", null });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f789e20-4e34-4b27-a672-b50c070a46af", "AQAAAAEAACcQAAAAEMeILJPr76lxem/5fMOY8dyJYp9t98VE/6vA2snCb5D4aJ+seNHURosT5FYUbcOhnA==", "35fd4775-3d9b-4f29-9409-08684c4cf6f8" });
        }
    }
}
