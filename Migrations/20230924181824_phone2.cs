using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class phone2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ca4693-3045-4a85-8e80-9ee7ddb2fb5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d480c9e2-3a5a-4fac-be17-01f89bd36236");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Profiles",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "305ed44b-ca50-45e0-9603-10cf40a9bb73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c04471d7-7800-4e70-8e8b-c521fe15b127");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Profiles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

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
    }
}
