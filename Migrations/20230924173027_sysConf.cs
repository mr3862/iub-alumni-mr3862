using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class sysConf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d94b3dcc-ffcb-4fbf-8dfb-83e9c4acb7cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e596f95f-3b57-4ade-977e-910d9a542f70");

            migrationBuilder.CreateTable(
                name: "SysConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTS = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysConfigs", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "SysConfigs",
                columns: new[] { "Id", "CreateTS", "CreateUser", "Key", "Type", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 24, 13, 30, 27, 432, DateTimeKind.Local).AddTicks(4292), "System", "EmailSender", "Basic", "mr3862@columbia.edu" },
                    { 2, new DateTime(2023, 9, 24, 13, 30, 27, 432, DateTimeKind.Local).AddTicks(4371), "System", "EmailSenderName", "Basic", "IUB Alumni - North America" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysConfigs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6391f5dc-c372-4161-a283-bbea02875c98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7038eb28-5f3e-4d3f-8de1-b2aad2253fad");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "006ace8c-f236-47a3-ad20-0a150e5e8ac0", "AQAAAAEAACcQAAAAEFSrcoAx04IeeQQzPttUEthyOIEC4p5fdpsXGZsHvjwxQtvHXizP4UDjgr51lqpLHA==", "dfdce904-748c-4e18-bd2e-f124dd8e976b" });
        }
    }
}
