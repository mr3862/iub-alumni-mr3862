using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class phone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6391f5dc-c372-4161-a283-bbea02875c98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7038eb28-5f3e-4d3f-8de1-b2aad2253fad");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Profiles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d98a5647-46df-46bb-a4de-202c35c64508");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96ca4693-3045-4a85-8e80-9ee7ddb2fb5b", "4a2860c2-fe2c-4abd-aebf-6d212b308bb2", "Admin", "ADMIN" },
                    { "d480c9e2-3a5a-4fac-be17-01f89bd36236", "29afebb6-576d-4c51-b259-2bc42f6ed944", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afee539c-1415-4897-8f21-d61442b34a51", "AQAAAAEAACcQAAAAEIFzz57SGEFgfd+xm5Wmede8xuxuTucL42bOo7VQGa1Az225hkpGEXy4jqpMEHog+g==", "010fdf0a-d937-4c39-afdd-55b39a35ab55" });

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTS",
                value: new DateTime(2023, 9, 24, 13, 51, 14, 84, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTS",
                value: new DateTime(2023, 9, 24, 13, 51, 14, 84, DateTimeKind.Local).AddTicks(7099));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ca4693-3045-4a85-8e80-9ee7ddb2fb5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d480c9e2-3a5a-4fac-be17-01f89bd36236");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Profiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b327a6e0-00d0-41be-b7fd-bd84cf23f63b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6391f5dc-c372-4161-a283-bbea02875c98", "c457e4df-5381-4570-ada2-8a0422d5e1ad", "Admin", "ADMIN" },
                    { "7038eb28-5f3e-4d3f-8de1-b2aad2253fad", "0d2f8b11-5e1f-4eb0-9f86-dbf609ca09f9", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d390ce91-0c68-48d7-8c8c-56c6fa409c51", "AQAAAAEAACcQAAAAENd86habCpVFwsnqVjaCtd2mLxKa/Im+dg9xKvoEjgaMWuqjf6WH3Gq6JWVCtA/Ttg==", "281d98d5-e394-43e1-bfbf-6fc72710294d" });

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTS",
                value: new DateTime(2023, 9, 24, 13, 30, 27, 432, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTS",
                value: new DateTime(2023, 9, 24, 13, 30, 27, 432, DateTimeKind.Local).AddTicks(4371));
        }
    }
}
