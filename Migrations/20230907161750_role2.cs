using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class role2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4619dae8-02da-414d-99f7-f3e2ed3a9467");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca39925-6d8c-40b6-940d-31cab4b1dfcb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1", "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "b0aac938-6148-441c-ad7f-4f71a6e5b0de", "SuperAdmin", "SUPERADMIN" },
                    { "28f59d73-2cc1-40d6-a9c7-27f0af764b77", "8c11b398-be49-4b2a-980d-6582be7727de", "Admin", "ADMIN" },
                    { "ffef4f9d-dcaf-46b6-b63e-32e70d1c0fa9", "c59c0b40-18e6-4911-ab0c-4eeb408e9a9f", "Basic", "BASIC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "3031a442-4e88-482e-a688-19097c2ccbe3", "SuperAdmin@aaina.org", true, false, null, "SUPERADMIN@AAINA.ORG", "SUPERADMIN@AAINA.ORG", "AQAAAAEAACcQAAAAEOWzRJfcF7E9ZF14zGiFZd82tS0ASZPSLaL6jk0WMGOma/aIJiplnNAamIA9tMIWCw==", null, false, "444e55a5-d72e-4e9a-a33c-a56932e4458a", false, "SuperAdmin@aaina.org" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28f59d73-2cc1-40d6-a9c7-27f0af764b77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffef4f9d-dcaf-46b6-b63e-32e70d1c0fa9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4619dae8-02da-414d-99f7-f3e2ed3a9467", "0fca8c4a-6898-40d9-ad1d-c57886dc64b7", "Basic", "BASIC" },
                    { "6ca39925-6d8c-40b6-940d-31cab4b1dfcb", "73fe4199-b049-4a17-afd7-58b98ab903cf", "Admin", "ADMIN" },
                    { "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1", "c0e63d9d-f493-49b0-a9b0-b2cf9a1a4f8b", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2", 0, "c89f19fa-16f3-4b73-a502-c9622122c896", "SuperAdmin@aaina.org", true, false, null, "SUPERADMIN@AAINA.ORG", "SUPERADMIN@AAINA.ORG", "AQAAAAEAACcQAAAAEA2/VkMyqM7ZjXAEMheJXWOsz19bHopd9c7iJ7ECBqJRrK3rls//HmLjkNP+CGRHxw==", null, false, "41842daa-e9bb-4670-9de0-946fb71f0de6", false, "SuperAdmin@aaina.org" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1", "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2" });
        }
    }
}
