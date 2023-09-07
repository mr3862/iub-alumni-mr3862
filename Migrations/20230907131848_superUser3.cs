using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class superUser3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "503579be-ce50-4373-8dee-d8a1c4b1432f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d692c481-8f8c-42f8-bb3b-61dc93d58cd5");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a738ab2-72ba-4a3a-9082-5ed87949b48b", "AQAAAAEAACcQAAAAEBH32tVswhILXbqo03WP4A7gmaw1DE9EPNiygtxx/X+J0ZDJys3m0KF+6WIJZfU1IQ==", "ea42358a-9b43-477e-b6e1-070406073b6e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "20fb0390-8a6d-4912-a95e-5807d5568522");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "503579be-ce50-4373-8dee-d8a1c4b1432f", "7419fa2d-dfc6-4d7f-ae18-92197b2f4cfe", "Basic", null },
                    { "d692c481-8f8c-42f8-bb3b-61dc93d58cd5", "e86fb6c3-1c41-4446-8983-d327f9d2f012", "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffffffff-eeee-dddd-cccc-bbbbbbbbbbb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06abc193-9706-489b-8b63-e6675daedc49", "AQAAAAEAACcQAAAAEB7MWwaB+gKGDthAwP/uvkdKXOC1haWytE5Hvfuc+YCbk7n2bEP8WKO4/SfhqP6Vdg==", "93bac7d5-62e0-40e6-85ca-4c10a2b75a44" });
        }
    }
}
