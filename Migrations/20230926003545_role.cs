using System;
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
                keyValue: "305ed44b-ca50-45e0-9603-10cf40a9bb73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c04471d7-7800-4e70-8e8b-c521fe15b127");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f98769ed-825c-42b0-832d-661302d2de29");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2", "7c100771-cf76-4e73-8c54-b2ff160dcfed", "Admin", "ADMIN" },
                    { "3", "b1ebb7a9-cefd-49c0-adbb-3d7362f13e0f", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d719571-122b-4a4a-ac6b-d11070ed701f", "AQAAAAEAACcQAAAAEDf+9ToJF2zQxjfyt3enhBOpE5dJMJKrg4TIjildcdu6qmb7vm/YPHbAjNuvSDE9JA==", "224a3aa2-ced1-4636-9c8b-aec4dcfa6af2" });

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTS",
                value: new DateTime(2023, 9, 25, 20, 35, 44, 884, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTS",
                value: new DateTime(2023, 9, 25, 20, 35, 44, 884, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5dd0586b-12a5-4c8e-87ed-4725882599e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "305ed44b-ca50-45e0-9603-10cf40a9bb73", "2117b64d-a9ee-409d-b81a-557baa71bbba", "Admin", "ADMIN" },
                    { "c04471d7-7800-4e70-8e8b-c521fe15b127", "408d2ad7-c20d-4771-92c9-9db8f33800c3", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e5a6a57-f5c4-4033-892c-ae08a8b435ac", "AQAAAAEAACcQAAAAEMZSTQVuLzK4q9styag8Q/XxKKxZIIi9iqvZVR8+JfSRintAhRjsFo9LreM9FV2bSg==", "d6fdfedb-314d-40a4-8e4f-ef793ed91c63" });

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTS",
                value: new DateTime(2023, 9, 24, 14, 18, 23, 888, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "SysConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTS",
                value: new DateTime(2023, 9, 24, 14, 18, 23, 888, DateTimeKind.Local).AddTicks(4934));
        }
    }
}
