using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class superUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

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
                    { "503579be-ce50-4373-8dee-d8a1c4b1432f", "7419fa2d-dfc6-4d7f-ae18-92197b2f4cfe", "Basic", null },
                    { "d692c481-8f8c-42f8-bb3b-61dc93d58cd5", "e86fb6c3-1c41-4446-8983-d327f9d2f012", "Admin", null },
                    { "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1", "20fb0390-8a6d-4912-a95e-5807d5568522", "SuperAdmin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2", 0, "06abc193-9706-489b-8b63-e6675daedc49", "SuperAdmin@aaina.org", true, false, null, null, null, "AQAAAAEAACcQAAAAEB7MWwaB+gKGDthAwP/uvkdKXOC1haWytE5Hvfuc+YCbk7n2bEP8WKO4/SfhqP6Vdg==", null, false, "93bac7d5-62e0-40e6-85ca-4c10a2b75a44", false, "SuperAdmin@aaina.org" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb1", "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "503579be-ce50-4373-8dee-d8a1c4b1432f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d692c481-8f8c-42f8-bb3b-61dc93d58cd5");

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
                    { "1", "8b7105b5-8264-49c4-9020-b3e223369c26", "SuperAdmin", null },
                    { "2", "50214112-35a2-432f-8529-6ea335820717", "Admin", null },
                    { "3", "92d9c4ac-973d-49eb-97c2-e4f1eac76a77", "Basic", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "2015c04d-a6b6-44eb-8cf1-9008e679a3ae", "SuperAdmin@aaina.org", true, false, null, null, null, "AQAAAAEAACcQAAAAELfXhsOSVxALBatjSwk5NXFX0l/7s1zM6f2NePnlESCb0xrDAuiSSdRVSBlJhFiASw==", null, true, "682e7eb5-fe95-44fe-a38b-2a3b7e6a29f6", false, "SuperAdmin@aaina.org" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }
    }
}
